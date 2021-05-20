

<h3>Bienvenue sur la page news, ou tout ce que je juge important sera affiché. Elle sert également de vitrine, car tout ceci est lié à une base de données :)</h3>
<br/> <br/>

<?php
$lesNews = GestionNews::getLesNews();
foreach ($lesNews as $uneNews){
    ?>
<article id ="articleNews">
    <h1><?php echo $uneNews->titreNews;?></h1>
    <h3><?php echo $uneNews->contenuNews;?></h3>
    <h6><?php echo $uneNews->dateEcriture;?></h6>
</article>
<?php } ?>

