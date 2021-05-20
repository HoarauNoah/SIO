<?php

class ModelePDO {

    protected static $serveur = MySqlConfig::SERVEUR;
    protected static $base = MySqlConfig::BASE;
    protected static $utilisateur = MySqlConfig::UTILISATEUR;
    protected static $passe = MySqlConfig::MOT_DE_PASSE;
    protected static $pdoCnxBase = null;
    protected static $pdoStResults = null;
    protected static $requete = "";
    protected static $resultat = null;

    protected static function seConnecter() {
        if (!isset(self::$pdoCnxBase)) { //S'il n'y a pas encore eu de connexion
            try {
                self::$pdoCnxBase = new PDO('mysql:host=' . self::$serveur . ';dbname=' . self::$base, self::$utilisateur, self::$passe);
                self::$pdoCnxBase->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
                self::$pdoCnxBase->setAttribute(PDO::ATTR_DEFAULT_FETCH_MODE, PDO::FETCH_OBJ);
                self::$pdoCnxBase->query("SET CHARACTER SET utf8"); //méthode de la classe PDO
            } catch (Exception $e) {
                echo 'Erreur : ' . $e->getMessage() . '<br />'; // méthode de la classe Exception
                echo 'Code : ' . $e->getCode(); // méthode de la classe Exception
            }
        }
    }

    protected static function seDeconnecter() {
        self::$pdoCnxBase = null;
// Si on n'appelle pas la méthode, la déconnexion a lieu en fin de script
    }

    /**
     * @param $table
     * @return null
     */
    protected static function getLesTuples($table) {
        return ModelePDO::SelectTout("*", $table);
    }

    /**
     * @param $table
     * @param $nomChamp
     * @param $valeurChamp
     * @return null
     */
    protected static function getPremierTupleByChamp($table, $nomChamp, $valeurChamp) {
        return ModelePDO::selectFirst($nomChamp, $table, $valeurChamp);
    }
    protected static function getLesTuplesByChamp($table, $nomChamp, $valeurChamp) {
        return ModelePDO::SelectTout($nomChamp, $table, $valeurChamp);
    }

    protected static function supprimerTupleByChamp($table, $nomChamp, $valeurChamp) {
        self::seConnecter();
        if (is_object($valeurChamp)) {
            self::$requete = "DELETE FROM " . $table . " WHERE " . $nomChamp . "  = $valeurChamp->id";
        } else {
            self::$requete = "DELETE FROM " . $table . " WHERE " . $nomChamp . "  = $valeurChamp";
        }
        self::$pdoStResults = self::$pdoCnxBase->prepare(self::$requete);
        self::$pdoStResults->execute();
    }

    protected static function selectFirst($champs, $tables, $conditions = null) {
        self::seConnecter();
        if ($conditions == null) {
            self::$requete = "SELECT " . $champs . " FROM " . $tables;
            self::$pdoStResults = self::$pdoCnxBase->prepare(self::$requete);
        } else {
            self::$requete = "SELECT " . $champs . " FROM " . $tables . " WHERE " . $champs . " = :conditions";
            self::$pdoStResults = self::$pdoCnxBase->prepare(self::$requete);
            self::$pdoStResults->bindValue(':conditions', $conditions);
        }



        self::$pdoStResults->execute();
        self::$resultat = self::$pdoStResults->fetch(PDO::FETCH_OBJ);
        self::$pdoStResults->closeCursor();
        return self::$resultat;
    }


        protected static function SelectTout($champs, $tables,$conditions = null) {
        self::seConnecter();
        if ($conditions == null) {
            self::$requete = "SELECT " . $champs . " FROM " . $tables;
            self::$pdoStResults = self::$pdoCnxBase->prepare(self::$requete);
        } else {
            self::$requete = "SELECT " . $champs . " FROM " . $tables . " WHERE " . $conditions;
            self::$pdoStResults = self::$pdoCnxBase->prepare(self::$requete);
            self::$pdoStResults->bindValue(':conditions', $conditions);
        }
        self::$pdoStResults->execute();
        self::$resultat = self::$pdoStResults->fetchAll(PDO::FETCH_OBJ);
        self::$pdoStResults->closeCursor();
        return self::$resultat;
    }

}

?>