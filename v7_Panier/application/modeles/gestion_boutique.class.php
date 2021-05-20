<?php

require_once 'ModelePDO.class.php';

//require_once '../../configs/mysql_config.class.php';
class GestionBoutique extends ModelePDO
{

    public static function getLesCategories()
    {
        return ModelePDO::getLesTuples("categorie");
    }

    public static function getLesCategoriesById($id){
        self::seConnecter();
        self::$requete = "SELECT * FROM categorie where id = :id";
        self::$pdoStResults = self::$pdoCnxBase->prepare(self::$requete);
        self::$pdoStResults->bindValue('id', $id);
        self::$pdoStResults->execute();
        self::$resultat = self::$pdoStResults->fetch();
        self::$pdoStResults->closeCursor();
        return self::$resultat;
    }

//    public static function getLesProduits(){
//        return GestionBoutique::getLesTuplesByTable("produit");
//    }

    public static function getLesProduitsByCategorie($libelleCateg)
    {
        return ModelePDO::SelectTout("produit.*, categorie.libelle", "categorie, produit", "categorie.libelle='" . $libelleCateg . "' and produit.idCategorie = categorie.id");
    }

    public static function getLesProduits()
    {
        self::seConnecter();
        self::$requete = "SELECT produit.*, categorie.libelle as 'libelleCateg' FROM categorie, produit where categorie.id = produit.idCategorie ";
        self::$pdoStResults = self::$pdoCnxBase->prepare(self::$requete);
        self::$pdoStResults->execute();
        self::$resultat = self::$pdoStResults->fetchAll();
        self::$pdoStResults->closeCursor();
        return self::$resultat;
    }

    public static function getNbProduit()
    {
        self::seConnecter();
        self::$requete = "SELECT COUNT(*) AS nbProduits FROM produit";
        self::$pdoStResults = self::$pdoCnxBase->prepare(self::$requete);
        self::$pdoStResults->execute();
        self::$resultat = self::$pdoStResults->fetch();
        self::$pdoStResults->closeCursor();
        return self::$resultat->nbProduits;
    }

    /**
     * Ajoute une ligne dans la table Categorie
     * @param type $libelleCateg libellé de la catégorie
     */
    public static function ajouterCategorie($libelleCateg)
    {
        self::seConnecter();
        self::$requete = "INSERT into categorie (libelle) values (:libelleCateg)";
        self::$pdoStResults = self::$pdoCnxBase->prepare(self::$requete);
        self::$pdoStResults->bindValue('libelleCateg', $libelleCateg);
        self::$pdoStResults->execute();
    }

    public static function ajouterProduit($idProduit, $libelleProduit, $description, $prix, $image, $idCat)
    {
        self::seConnecter();
        self::$requete = "INSERT into produit (id, nom, description, prix, image, idCategorie) values ($idProduit,'$libelleProduit', '$description', $prix, '$image', $idCat)";
        var_dump(self::$requete);
        self::$pdoStResults = self::$pdoCnxBase->prepare(self::$requete);
        self::$pdoStResults->execute();
    }

    public static function modifierProduit($idProduit, $libelleProduit, $description, $prix, $image, $idCat)
    {
        self::seConnecter();
        self::$requete = "UPDATE produit SET nom = '$libelleProduit', description = '$description', prix = '$prix', image ='$image', idCategorie = $idCat WHERE produit.id = $idProduit";
        var_dump(self::$requete);
        self::$pdoStResults = self::$pdoCnxBase->prepare(self::$requete);
        self::$pdoStResults->execute();
    }

    public static function modifierCategorie($idCategorie, $libelleCategorie)
    {
        self::seConnecter();
        self::$requete = "UPDATE categorie SET libelle = '$libelleCategorie' WHERE categorie.id = $idCategorie";
        var_dump(self::$requete);
        self::$pdoStResults = self::$pdoCnxBase->prepare(self::$requete);
        self::$pdoStResults->execute();
    }

    public static function delCategorie($idCategorie)
    {
        self::seConnecter();
        self::$requete = "DELETE FROM categorie WHERE categorie.id = $idCategorie";
        var_dump(self::$requete);
        self::$pdoStResults = self::$pdoCnxBase->prepare(self::$requete);
        self::$pdoStResults->execute();
    }

    public static function delProduit($idProduit)
    {
        self::seConnecter();
        self::$requete = "DELETE FROM produit WHERE produit.id = $idProduit";
        var_dump(self::$requete);
        self::$pdoStResults = self::$pdoCnxBase->prepare(self::$requete);
        self::$pdoStResults->execute();
    }

    private static function getLesTuplesByTable($table)
    {
        self::seConnecter();
        self::$requete = "SELECT * FROM $table";
        self::$pdoStResults = self::$pdoCnxBase->prepare(self::$requete);
        self::$pdoStResults->execute();
        self::$resultat = self::$pdoStResults->fetchAll();
        self::$pdoStResults->closeCursor();
        return self::$resultat;
    }

    public static function isAdminOk($login, $passe)
    {
        self::seConnecter();
        self::$requete = "SELECT * FROM admin where login=:login and passe=:passe";
        self::$pdoStResults = self::$pdoCnxBase->prepare(self::$requete);
        self::$pdoStResults->bindValue('login', $login);
        self::$pdoStResults->bindValue('passe', sha1($passe));
        self::$pdoStResults->execute();
        self::$resultat = self::$pdoStResults->fetch();

        self::$pdoStResults->closeCursor();
        if (self::$resultat != null) {
            return TRUE;
        } else {
            return FALSE;
        }
    }

// /!\
// A MODIFIER isClientOK (17/11/2020)
// /!\

    public static function isClientOk($login, $passe)
    {

        self::seConnecter();
        self::$requete = "SELECT * FROM client where pseudoClient=:login and passeClient=:passe";
        self::$pdoStResults = self::$pdoCnxBase->prepare(self::$requete);
        self::$pdoStResults->bindValue('login', $login);
        self::$pdoStResults->bindValue('passe', sha1($passe));
        self::$pdoStResults->execute();
        self::$resultat = self::$pdoStResults->fetch();

        self::$pdoStResults->closeCursor();
        if (self::$resultat != null) {
            return TRUE;
        } else {
            return FALSE;
        }
    }

    public static function newClient($login, $passe, $mail, $nom, $prenom, $codePostal, $ville)
    {

            self::seConnecter();
            self::$requete = "INSERT INTO client value (:login,:passe,:mail,:nom,:prenom,:codePostal,:ville)";
            self::$pdoStResults = self::$pdoCnxBase->prepare(self::$requete);
            self::$pdoStResults->bindValue('login', $login);
            self::$pdoStResults->bindValue('passe', sha1($passe));
            self::$pdoStResults->bindValue('mail', $mail);
            self::$pdoStResults->bindValue('nom', $nom);
            self::$pdoStResults->bindValue('prenom', $prenom);
            self::$pdoStResults->bindValue('codePostal', $codePostal);
            self::$pdoStResults->bindValue('ville', $ville);
            self::$pdoStResults->execute();
            return True;

    }

    public static function getExistClientByPseudo($pseudo)
    {
        self::seConnecter();
        self::$requete = "select count(*) as nbResultats from client where pseudoClient ='" . $pseudo . "'";
        self::$pdoStResults = self::$pdoCnxBase->prepare(self::$requete);
        self::$pdoStResults->execute();
        self::$resultat = self::$pdoStResults->fetch();
        self::$pdoStResults->closeCursor();
        return self::$resultat->nbResultats;
    }

    public static function getProduitById($id)
    {
        self::seConnecter();
        self::$requete = "select produit.*, categorie.libelle as libelleCateg from produit, categorie where categorie.id = produit.idCategorie and produit.id = :id";
        self::$pdoStResults = self::$pdoCnxBase->prepare(self::$requete);
        self::$pdoStResults->bindValue('id', $id);
        self::$pdoStResults->execute();
        self::$resultat = self::$pdoStResults->fetch();
        self::$pdoStResults->closeCursor();
        return self::$resultat;
    }
}

?>
<?php

?>


