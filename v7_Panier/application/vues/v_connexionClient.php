<script type="text/javascript" src="public/js/jquery.js"></script>
<script type="text/javascript" src="public/js/jquery.autocomplete.js"></script>
<form id="connexion" action="index.php?cas=verifierConnexionClient" method="post">
<fieldset>
    <legend> Identification </legend>
    <label for="pseudo">Pseudo :</label> <input type='text' name='login' id='pseudo'/><span> </span><br /> 
    <label for="pass1"> Mot de passe :</label><input type='password' name='passe' id='pass1'/><span> </span><br /> <br/>
    <input type='submit' name='valider' id='valider' value='VALIDER' />
</fieldset>
    <h2> <a href ="index.php?cas=creationCompte"> Nouveau client </h2>
</form>
