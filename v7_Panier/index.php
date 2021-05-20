<?php
session_start();
require_once 'configs/chemins.class.php';
include Chemins::VUES_PERMANENTES . '/v_entete.inc.php';
require_once 'configs/mysql_config.class.php';
require_once Chemins::MODELES . 'gestionNews.class.php';
require_once Chemins::MODELES . 'gestion_boutique.class.php';
require_once Chemins::CONFIGS . 'variables_globales.class.php';
require_once Chemins::CONTROLEURS . 'controleur_categories.class.php';
require_once Chemins::CONTROLEURS . 'controleur_produit.class.php';
require_once Chemins::MODELES . 'panier.class.php';

$controleurProduits = new ControleurProduits();

//$controleurCategories = new ControleurCategories();
//$controleurCategories->afficher();

if (!isset($_REQUEST['cas'])) {
    $cas = 'accueil';
} else {
    $cas = $_REQUEST['cas'];
}
if (isset($_COOKIE['login_admin']))
    $_SESSION['login_admin'] = $_COOKIE['login_admin'];

//Aiguillage vers le bon corps de page
//switch($cas){
//    case 'accueil':{
//        require 'pages/accueil.php';
//        break;
//    }
//    case 'cyberportfolio':{
//        if(file_exists('pages/'.$cas.'.php')){
//            require 'pages/'.$cas.'.php';
//            break;
//        }
//    }
//    case 'news':{
//        if(file_exists('pages/'.$cas.'.php')){
//            require'pages/'.$cas.'.php';
//            break;
//        }
//    } case 'connexion':{
//        if(file_exists('pages/'.$cas.'.php')){
//            require'pages/'.$cas.'.php';
//            break;
//        }
//    }
//    default :{
//            require 'pages/error404.php';
//            break;
//    }
//}

switch ($cas) {
    case 'accueil':
    {
        require Chemins::VUES . 'v_accueil.php';
        break;
    }
    case 'boutique' :
    {
        if (!isset($_REQUEST['categorie'])) {
            $controleurProduits->afficherTout();
        } else {
            $controleurProduits->afficher($_REQUEST['categorie']);
        }
        break;
    }
    case 'afficherIndexAdmin':
    {
        if (isset($_SESSION['login_admin']))
            require Chemins::VUES_ADMIN . 'v_index_admin.inc.php';
        else
            require Chemins::VUES_ADMIN . 'v_connexion.inc.php';
        break;
    }
    case 'verifierConnexionAdmin':
    {
        if (GestionBoutique::isAdminOk($_POST['login'], $_POST['passe'])) {
            $_SESSION['login_admin'] = $_POST['login'];
            if (isset($_POST['connexion_auto'])) {
                setcookie('login_admin', $_POST['login'], time() + 7 * 24 * 3600, null, null, false, true);
            }
            require Chemins::VUES_ADMIN . 'v_index_admin.inc.php';
        } else
            require Chemins::VUES_ADMIN . 'v_acces_interdit.inc.php';
        break;
    }

    case 'verifierConnexionClient':
    {
        if (GestionBoutique::isClientOk($_POST['login'], $_POST['passe']) == true) {
            $_SESSION['login_client'] = $_POST['login'];
            if (isset($_POST['connexion_auto'])) {
                setcookie('login_client', $_POST['login'], time() + 7 * 24 * 3600, null, null, false, true);
            }
            Panier::initialiser();
            header("Location: ?cas=boutique");
        } else {
            echo('compte inconnu');
            require Chemins::VUES . 'v_connexionClient.php';
        }
        break;
    }
    case 'seDeconnecter':
    {
        $_SESSION = array();
        session_destroy();
        setcookie('login_admin', '');
        setcookie('login_client', '');
        Panier::detruire();
        header("Location:index.php");
        break;
    }

    default :
    {
        if (file_exists(Chemins::VUES . "v_" . $cas . '.php')) {
            require Chemins::VUES . "v_" . $cas . '.php';
        } else {
            require Chemins::VUES . "v_error404.php";
        }

        break;
    }
    case 'voirPanier':
    {
        if(isset($_SESSION['login_client'])) {
            require Chemins::VUES . "v_panier.php";
        }
        else{
            require Chemins::VUES . "v_connexionClient.php";
        }
        break;

    }
    case 'connexionClient':
    {
        require Chemins::VUES . "v_connexionClient.php";
        break;
    }
    case'inscrireClient':
    {
        GestionBoutique::newClient($_POST['pseudo'], ($_POST['pass1']), $_POST['mail'], $_POST['nom'], $_POST['prenom'], $_POST['cp'], $_POST['ville']);
        echo('Inscription réussie !');
        require Chemins::VUES . "v_connexionClient.php";
    }

}

include Chemins::VUES_PERMANENTES . 'v_footer.inc.php';


