<?php

/* 
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
class ControleurCategories {
public function __construct() {
// si on séparait les modèles, le constructeur donnerait son chemin
// require_once Chemins::MODELES.'gestion_categories.class.php';
}
public function afficher() {
VariablesGlobales::$lesCategories = GestionBoutique::getLesCategories();
}
}
?>


