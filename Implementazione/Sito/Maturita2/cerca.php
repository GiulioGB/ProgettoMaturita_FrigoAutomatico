<html>
	<head>
		<title>paginaRicerca</title>
		<link href="css/mioStileRicerca.css" rel="stylesheet">
		<link href="css/font-awesome.min.css" rel="stylesheet">
		<link href='http://fonts.googleapis.com/css?family=Lobster' rel='stylesheet' type='text/css'>
	</head>
<body>
	
	
	<div id="MIOdivRicerca" align="center" >
		<div class="container">
			<div class="row">
				<div class="section-title text-center">
					<h3>Risultati ricerca</h3>
					
					<?php
						session_start(); 
	
						@include("connessione.php");

						//seleziono il database da usare
						mysqli_select_db($link, "data_frigo");

						//imposto la query
						$nomeProdotto = $_POST['prodotto'];
						$result = mysqli_query($link, "SELECT NomeAlimento , dataScadenza , EAN , luogoProduzione , Quantita FROM prodotto WHERE NomeAlimento = '".$nomeProdotto."' AND IDFrigo = ( SELECT ID 
																																		 FROM frigo
																																		 WHERE Username ='".$_SESSION["CodiceFrigo"]."')");
						if( mysqli_num_rows ( $result ) > 0)
						{
						echo "</br></br>";
						echo "<table align='center' >";
						echo "<tr><th>&nbsp;&nbsp; EAN &nbsp;&nbsp;</th><th> &nbsp;&nbsp; Nome &nbsp;&nbsp; </th><th> &nbsp;&nbsp; Data scadenza &nbsp;&nbsp;</th><th> &nbsp;&nbsp; Luogo produzione &nbsp;&nbsp;</th><th> &nbsp;&nbsp; Quantita' &nbsp;&nbsp;</th></tr>";
						
						while($row = mysqli_fetch_array( $result, MYSQL_BOTH)){
					
							//$stringa = $row['Nome']."/".$row['dataScadenza'];
							//array_push($vett, $stringa ); 
							//printf("Nome: %s Data: %s ", $row['Nome'], $row['dataScadenza']);
							//$s++;
							echo "<tr><td align='center'>".$row["EAN"]."</td><td align='center'>".$row["NomeAlimento"]."</td><td align='center'>".$row["dataScadenza"]."</td><td align='center'>".$row["luogoProduzione"]."</td><td align='center'>".$row["Quantita"]."</td></tr>";
						}
						
						echo "</table>";
						echo "</br></br>";
						
						}else echo "Il prodotto cercato non e' presente nel database"."</br></br>";
					?>
					
					<input type="button" id="torna" name="torna" value="INDIETRO" onClick="window.location.href ='ricerca.php'"> &nbsp;&nbsp;&nbsp;
					<input type="button" id="torna" name="torna" value="HOME PAGE" onClick="window.location.href ='index.php'"> </br></br>
				</div>
			</div>
		</div>
    </div>
	
	
</body>
</html>