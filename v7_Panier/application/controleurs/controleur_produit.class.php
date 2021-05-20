<?php

/* 
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
class ControleurProduits{
    public function __construct() {
        
    }
    public function afficher($laCategorie){
        VariablesGlobales::$lesProduits = GestionBoutique::getLesProduitsByCategorie($laCategorie);
        require Chemins::VUES.'v_boutique.php';
    }
    public function afficherTout(){
        VariablesGlobales::$lesProduits = GestionBoutique::getLesProduits();
        require Chemins::VUES.'v_boutique.php';
    } 
}
