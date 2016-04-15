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


	while($row = mysqli_fetch_array( $result, MYSQL_BOTH)){
		
		$SESSION['nomeP'] = $row['Nome'];
		$SESSION['dataS'] = $row['dataScadenza'];
		//printf("Nome: %s Data: %s ", $row['Nome'], $row['dataScadenza']);
		$s=1;
	}

	if($s = 0)
		$SESSION['nomeP'] = "null";
		
	
	
	mysqli_free_result($result); 
	header(ricerca.php);
	?>
</body>
</html>