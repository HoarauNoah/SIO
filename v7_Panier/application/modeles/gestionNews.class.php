<?php
require_once 'ModelePDO.class.php';
class GestionNews extends ModelePDO{
    // <editor-fold defaultstate="collapsed" desc="Champs statiques">
    // </editor-fold>
    // <editor-fold defaultstate="collapsed" desc="Méthodes statiques">
    
    
    
        public static function getLesNews() {
            return ModelePDO::getLesTuples("news");
        }
    }
//</editor-fold>
    

    
  
    
?>
    
    

