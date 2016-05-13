<html>
	<head>
		<title>paginaRicerca</title>
		
	</head>
<body>
	<?php
	
	session_start(); 
	
	$link = mysqli_connect("localhost","root");

	if(mysqli_connect_errno()){
		printf("Connessione al server fallita", mysqli_connect_error());
		exit();
	} 

	//seleziono il database da usare
	mysqli_select_db($link, "prova2");

	//imposto la query
	$nomeProdotto = $_POST['prodotto'];
	$result = mysqli_query($link, "SELECT Nome, dataScadenza FROM prodotti WHERE Nome = '$nomeProdotto' ");
	$s = 0;
	$vett = array();
	
	
	while($row = mysqli_fetch_array( $result, MYSQL_BOTH)){
		
		$stringa = $row['Nome']."/".$row['dataScadenza'];
		array_push($vett, $stringa ); 
		//printf("Nome: %s Data: %s ", $row['Nome'], $row['dataScadenza']);
		$s++;
	}
	
	
	if($s == 0)
		$_SESSION['s'] = 0;
	else
	{
		$_SESSION['s'] = 1;
		$_SESSION['result'] = serialize($vett);
	}
	
	mysqli_free_result($result); 
	header("location:ricerca.php");
	?>
</body>
</html>