<html>
	<head>
		<title>paginaRicerca</title>
		<link href="css/mioStileRicerca.css" rel="stylesheet">
		<link href="css/font-awesome.min.css" rel="stylesheet">
		<link href='http://fonts.googleapis.com/css?family=Lobster' rel='stylesheet' type='text/css'>
	</head>
<body>
	<?php
	
	session_start(); 
	
	@include("connessione.php");

	//seleziono il database da usare
	mysqli_select_db($link, "data_frigo");

	//imposto la query
	$nomeProdotto = $_POST['prodotto'];
	$result = mysqli_query($link, "SELECT Nome, dataScadenza , Barcode FROM prodotto WHERE Nome = '".$nomeProdotto."' AND IDFrigo = ( SELECT ID 
																													 FROM frigo
																													 WHERE Username ='".$_SESSION["CodiceFrigo"]."')");
	
	$vett = array();
	
	
	//if($s == 0)
	//	$_SESSION['s'] = 0;
	//else
	//{
	//	$_SESSION['s'] = 1;
	//	$_SESSION['result'] = serialize($vett);
	//}
	
	//mysqli_free_result($result); 
	//header("location:ricerca.php");
	
	
	?>
	
	<div id="MIOdivRicerca" align="center" >
		<div class="container">
			<div class="row">
				<div class="section-title text-center">
					<h3>Risultati ricerca</h3>
					
					<?php
						//if($s == 0)
						//{
							
						//} else
						//{	
						//	foreach($vett as $a)
						//		echo $a;
						//}
						if($row = mysqli_fetch_array( $result, MYSQL_BOTH))
						{
						echo "</br></br>";
						echo "<table align='center' >";
						echo "<tr><th>&nbsp;&nbsp; Barcode &nbsp;&nbsp;</th><th> &nbsp;&nbsp; Nome &nbsp;&nbsp; </th><th> &nbsp;&nbsp; Data scadenza &nbsp;&nbsp;</th></tr>";
						
						while($row = mysqli_fetch_array( $result, MYSQL_BOTH)){
					
							//$stringa = $row['Nome']."/".$row['dataScadenza'];
							//array_push($vett, $stringa ); 
							//printf("Nome: %s Data: %s ", $row['Nome'], $row['dataScadenza']);
							//$s++;
							echo "<tr><td align='center'>".$row["Barcode"]."</td><td align='center'>".$row["Nome"]."</td><td align='center'>".$row["dataScadenza"]."</td></tr>";
						}
						
						echo "</table>";
						echo "</br></br>";
						
						}else echo "Il prodotto cercato non e' presente nel database"."</br></br>";
					?>
					
					<input type="button" id="torna" name="torna" value="Ricerca" onClick="window.location.href ='ricerca.php'"> &nbsp;&nbsp;&nbsp;
					<input type="button" id="torna" name="torna" value="HOME_PAGE" onClick="window.location.href ='index.php'"> </br></br>
				</div>
			</div>
		</div>
    </div>
	
	
</body>
</html>