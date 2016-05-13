<?php
	session_start();
	unset($_SESSION["CodiceFrigo"]);
	header("location: index.php");
?>