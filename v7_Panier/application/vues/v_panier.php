<script>
    function popUpDelete() {
        alert("panier mis à jour !")
    }
</script>
<?php
if ($_POST != null)
{
    if ($_POST['qte'] == 0)
    {
        Panier::retirerProduit($_POST["idProduit"]);
    }
    else
        {
            Panier::modifierQteProduit(($_POST['idProduit']), ($_POST['qte']));
        }
    ?>
    <script> popUpDelete() </script>
    <?php
}
if((!Panier::isVide()))
{
    $lesProduits = Panier::getProduits();
    foreach ($lesProduits as $id => $unProduit)
    {
        ?>
        <article>
            <?php
            $leProduit = GestionBoutique::getProduitById($id);
            $laCategorie = GestionBoutique::getLesCategoriesById($leProduit->idCategorie);
            ?>
            <img class='imgBoutique' src="<?php echo "public/images/produits/".$leProduit->libelleCateg."/".$leProduit->image;?>" alt="photo"  />
            <aside>
                <h3><?= $leProduit->libelle ?></h3>
                <h5><?= $leProduit->description ?></h5>
                <h5>Prix unitire : <?= $leProduit->prix ?></h5>
                <h5> Quantitée : <?= Panier::getQteByProduit($leProduit->id) ?></h5>
                <form method="post" id="formPanier<?= $leProduit->id;?>">
                    <input type="hidden" name="idProduit" value="<?= $leProduit->id;?>">
                    <input type="number" name="qte" min=1 value="<?= Panier::getQteByProduit($leProduit->id);?>"/>
                    <img src="public/images/valider.png" width="35px" title="Mis à jour panier" onclick="document.getElementById('formPanier<?= $leProduit->id;?>').submit()"/>

                </form>
            <form method="post" id="formPanierDelete<?= $leProduit->id;?>">
                <input type="hidden" name="idProduit" value="<?= $leProduit->id;?>">
                <input type="hidden" name="qte" value="0"/>
                <img src="public/images/iconeX.png" width="35px" title="Supprimer du panier" onclick="document.getElementById('formPanierDelete<?= $leProduit->id;?>').submit()"/>
            </form>
            </aside>
            <br>
            <br>
            <br>
            </article>
        <?php
    }
}
else
{
    ?> <h3> Panier vide, retournez à la </h3> <a href="index.php?cas=boutique"> boutique </a>  <h3> pour ajouter des produits ! </h3> <?php
}
?>