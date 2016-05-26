				
<html>
	<head>
		<title>paginaRicerca</title>
		<link href="css/mioStileSpesa.css" rel="stylesheet">
		<link href="css/font-awesome.min.css" rel="stylesheet">
		<link href='http://fonts.googleapis.com/css?family=Lobster' rel='stylesheet' type='text/css'>
	</head>
<body>
	
	
	<div id="MIOdivRicerca" align="center" >
		<div class="container">
			<div class="row">
				<div class="section-title text-center">
					<h3>Lista della spesa</h3>
					
					<?php
							session_start(); 
							@include("connessione.php");
					
							$utente = $_POST["utente"];
							$i = 1;
							//seleziono il database da usare
							mysqli_select_db($link, "data_frigo");
							
							
							//imposto la query
							$result = mysqli_query($link, "SELECT Nome FROM alimento JOIN preferito ON IDFamiliare = IDAlimento WHERE IDFamiliare = (SELECT ID FROM familiare WHERE Nome ='".$utente."') 
															AND alimento.Nome NOT IN ( SELECT prodotto.NomeAlimento FROM prodotto WHERE 1) 
															");

							echo "</br></br>";
							echo "<table align='center' >";
							echo "<tr><th>&nbsp;&nbsp; Numero &nbsp;&nbsp;</th><th> &nbsp;&nbsp; Nome &nbsp;&nbsp; </th></tr>";
							while($row = mysqli_fetch_array( $result, MYSQL_BOTH)){
								echo "<tr><td align='center'>".$i."</td><td align='center'>".$row[0]."</td></tr>";
								$i++;
							}
							echo "</table>";
							echo "</br></br>";
							?>
					
					<input type="button" id="torna" name="torna" value="INDIETRO" onClick="window.location.href ='listaSpesa.php'"> &nbsp;&nbsp;&nbsp;
					<input type="button" id="torna" name="torna" value="HOME PAGE" onClick="window.location.href ='index.php'"> </br></br>
				</div>
			</div>
		</div>
    </div>
	
	
</body>
</html>