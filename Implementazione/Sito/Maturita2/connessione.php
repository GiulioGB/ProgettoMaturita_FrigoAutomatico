<?php

$link = mysqli_connect("localhost","root");

	if(mysqli_connect_errno()){
		printf("Connessione al server fallita", mysqli_connect_error());
			exit();
		} 
						
?>