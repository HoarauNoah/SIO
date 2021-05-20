    <script type="text/javascript" src="public/js/jquery.js"></script>
    <script type="text/javascript">
//        $(document).ready(function () {
//            $("#valider").click(function () {
//                formValide = true;
//                //Traitements de toutes les zones de saisies
//                $("#nouveauClient input[type=text], #nouveauClient input[type=password]").each(function () {
//                    if ($(this).val() == "") {
//                        $(this).next().addClass("message-erreur").text("Le champ est vide!").fadeIn();
//                        formValide = false;
//                    } else
//                        $(this).next().fadeOut();
//                    if ($(this).val() == "")
//                        $(this).next().addClass("message-erreur").text("Le champ est vide!").fadeIn();
//                    else
//                        switch ($(this).attr('id')) //Traitement selon l'id
//                        {
//                            case 'pseudo' :
//                                if (!$(this).val().match(/^[a-z]+$/i))
//                                    $(this).next().removeClass("message-ok").addClass("message-erreur").text("Pseudo non valide !").show();
//                                else
//                                    $(this).next().removeClass("message-erreur").addClass("message-ok").text("OK").show();
//                        }
//                });
//                //On valide ou pas le formulaire selon le booleen formValide
//                if (!$("#conditions").attr('checked')) {
//                    $("#erreurConditions").addClass("message-erreur").text("Acceptationobligatoire !").fadeIn();
//                    formValide = false;
//                } else
//                    $("#erreurConditions").fadeOut();
//                return formValide;
//
//                //Traitement de la case à cocher
//                $("#nouveauClient input[type=text], #nouveauClient input[type=password]").keypress(function () {
//                    $(this).next().fadeOut();
//                });
//                $("#conditions").click(function () {
//                    if ($(this).attr('checked'))
//                        $("#erreurConditions").fadeOut();
//                    else
//                        $("#erreurConditions").addClass("message-erreur").text("Acceptation obligatoire !").fadeIn();
//                });
//                if (formValide == true)
//                {
//                    document.location.href = "index.php?cas=inscrireClient";
//                }
//            });
        $(document).ready(function () {
            var formValide;
//TRAITEMENT DU CLICK SUR LE BOUTON VALIDER
//-----------------------------------------
            $("#valider").click(function () {
                formValide = true;
//Traitements de toutes les zones de saisies
                $("#nouveauClient input[type=text], #nouveauClient input[type=password]").each(function ()
                {
                    controleSaisie($(this).attr('id'));
                });
//Traitement de la case à cocher
                if (!$("#conditions").attr('checked')) {
                    $("#erreurConditions").addClass("message-erreur").text("Acceptation obligatoire !").fadeIn();
                    formValide = false;
                } else
                    $("#erreurConditions").fadeOut();
//On valide ou pas le formulaire selon le booleen formValide
                return formValide;
            });
//TRAITEMENT DU KEYPRESS DANS LES ZONES DE SAISIES :
// On efface le message lorsqu'on remplit les champs
//---------------------------------------------------
            $("#nouveauClient input[type=text], #nouveauClientinput[type=password]").keypress(function ()
            {
                $(this).next().fadeOut();
            });
//TRAITEMENT DU CLICK SUR LA CASE A COCHER (CONDITIONS GENERALES)
//---------------------------------------------------------------
            $("#conditions").click(function () {
                if ($(this).attr('checked'))
                    $("#erreurConditions").fadeOut();
                else
                    $("#erreurConditions").addClass("message-erreur").text("Acceptation obligatoire !").fadeIn();
            });
//TRAITEMENT LORSQUE LES ZONES DE SAISIES PERDENT LE FOCUS
//--------------------------------------------------------

            $("#nouveauClient input[type=text], #nouveauClient input[type=password]").blur(function ()
            {
                controleSaisie($(this).attr('id'));
            });
//-------------------------------------
// TRAITEMENT DES CONTROLES DE SAISIES
//-------------------------------------
            function controleSaisie(idchamp)
            {
                if ($("#" + idchamp).val() == "")

                {
                    $("#" + idchamp).next().removeClass("message-ok").addClass("message-erreur").text("Le champ est vide !").fadeIn();

                    formValide = false;
                } else {
                    var regex, messageErreur;
                    switch (idchamp) //Traitement selon l'id
                    {
                        case 'pseudo' :
                            regex = /^[a-z]+$/i;
                            messageErreur = "Pseudo non valide !";
                            break;

                        default :
                            regex = "";
                    }
                    traiterRegex(idchamp, regex, messageErreur);
                }
            }
            function traiterRegex(idchamp, regex, messageErreur)
            {
                if (idchamp == "pass2")
                {
                    var idChampPass1 = $("#pass1");
                    var idChampPass2 = $("#pass2");
                    if (idChampPass1.val() != idChampPass2.val())
                    {
                        idChampPass2.next().removeClass("message-ok").addClass("message-erreur").text("Mdp different").show();
                        formValide = false;
                    }else{
                        idChampPass2.next().removeClass("message-erreur").addClass("message-ok").text("OK").show();
                    }
                }
                else {
                    if (!$("#" + idchamp).val().match(regex)) {
                        $("#" + idchamp).next().removeClass("message-ok").addClass("message-erreur").text(messageErreur).show();

                        formValide = false;
                    } else
                        $("#" + idchamp).next().removeClass("message-erreur").addClass("message-ok").text("OK").show();
                }
            }
//-------------------------------------

        });

        //----------------------------------------
// TRAITEMENT VERIFICATION PSEUDO EXISTANT
//----------------------------------------
        function cherchePseudoBD() {
            $.ajax({
            async:false,
            type: "POST",
            url: "Libs/AJAX/chercherPseudo.php",
            data: "pseudo=" + $("#pseudo").val(),
            success: function (reponse) {
                if (reponse == 1)
                {
                    $("#pseudo").next().removeClass("message-ok").addClass("message - erreur").text("Et non ! Le pseudo existe déjà").show();
                    formValide = false;
                    pseudoExistant = true;
                }
                }
            }
            );
        }

    </script>
    <form id="nouveauClient" method="post" action ="index.php?cas=inscrireClient">
        <div class="titreCli">Nouveau compte CLIENT</div>
        <fieldset>
            <legend> Identification : </legend>
            <label for="pseudo">Pseudo choisi :</label> <input type='text' name='pseudo' id='pseudo' onfocusout="cherchePseudoBD()"/><span> </span><br />
            <label for="pass1"> Mot de passe :</label><input type='password'
                                                             name='pass1' id='pass1'/><span> </span><br />
            <label for="pass2"> Resaisir passe :</label><input type='password' name='pass2' id='pass2'/><span> </span><br />
        </fieldset>
        <fieldset>
            <legend> Coordonnées : </legend>
            <label for="mail">Adresse mail :</label> <input type='text' name='mail' id='mail'/><span> </span><br />
            <label for="nom">Nom :</label><input type='text' name='nom' id='nom'/><span> </span><br />
            <label for="prenom">Prénom :</label><input type='text' name='prenom' id='prenom'/><span> </span><br />
            <label for="cp">Code Postal :</label><input type='text' name='cp' id='cp'/><span> </span><br />
            <label for="ville">Ville :</label><input type='text' name='ville' id='ville'/><span> </span>
        </fieldset>
        <fieldset class="sansBordure">
            <br />
            <input name='conditions' id='conditions' type='checkbox'/><label for="conditions" class="enligne"> J'accepte les <a href='/'>conditions générales</a></label> <span id='erreurConditions'> </span><br /> 
            <br />
            <input type='submit' name='valider' id='valider' value='VALIDER' />
        </fieldset>
    </form>
    <link rel="stylesheet" type="text/css" href="public/styles/style.css" />
