<script type="text/javascript" src="public/js/jquery.js"></script>
<script type="text/javascript">
    function popUpAdd() {
        alert("Produit ajouté !");
    }
    </script>
<?php

if ($_POST != null)
{
    Panier::ajouterProduit(($_POST['idProduit']), ($_POST['qte']));
    ?>
    <script> popUpAdd() </script>
    <?php
}

if(isset($_REQUEST["categorie"]))
{
    $lesProduits = GestionBoutique::getLesProduitsByCategorie($_REQUEST["categorie"]);
    ?>
<h3> <?php echo $_REQUEST["categorie"]; ?> </h3> <?php
}
else
{
   $lesProduits = GestionBoutique::getLesProduits();
   ?>
   <h3>Bienvenue sur la boutique </h3>
   <?php if(isset($_SESSION["login_client"]))
   {
       ?> <h2> <a href="index.php?cas=voirPanier"> Votre panier </a> </br> <a href="index.php?cas=seDeconnecter"> Déconnexion </a> </h2> <?php
   }
   else
   {
       ?> <h2> <a href="index.php?cas=ConnexionClient"> Connexion </a> </h2> <?php
   }
}

$lesCategories = GestionBoutique::getLesCategories();?>

<nav id="LiensRapides">
                    <ul>
                        <li> <a href="index.php?cas=boutique"> accueil</a> </li> </br > </br>
                        <?php foreach ($lesCategories as $uneCategorie) {?>
                        <li> <a href="index.php?cas=boutique&categorie=<?php echo $uneCategorie->libelle;?>"><?php echo $uneCategorie->libelle;?></a></li> </br>
                        <?php }?>
                    </ul>
                </nav>
<section>

    
    
    
    
    
    <?php
   
   
    foreach (VariablesGlobales::$lesProduits as $unProduit) {
    ?>
        <article>
            <img class='imgBoutique' src="<?php echo "public/images/produits/".$unProduit->libelleCateg."/".$unProduit->image;?>" alt="photo"  />
            <aside>
                <h1><?= $unProduit->libelle;?></h1>
                <h3><?php echo $unProduit->description;?></h3>
                <p><?php echo $unProduit->libelle;?></p>
                <h3><?php echo $unProduit->prix;?></h3>
                <?php if(isset($_SESSION["login_client"])){ ?>
                    <form method="post" id="formPanier<?= $unProduit->id;?>">
                        <input type="hidden" name="idProduit" value="<?= $unProduit->id;?>">
                        <input type="number" name="qte" min=1 value="1"/>
                        <img src="public/images/ajouter_panier.png" title="Ajouter au panier" onclick="document.getElementById('formPanier<?= $unProduit->id;?>').submit()"/>
                    </form>

                <?php }?>
            </aside>
            </br>
            </br>
            </br>
        </article>

    <?php
      }
    ?>
</section>