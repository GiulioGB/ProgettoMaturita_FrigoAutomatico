<html>
	<head>
		<link href="css/mioStileRicerca.css" rel="stylesheet">
		<title>PaginaDiRicerca</title>
		<?php session_start(); 
		?>
	</head>
<body>
	<div id="MIOdivRicerca">
		<div class="container">
			<div class="row">
				<div class="section-title text-center">
					<form action="cerca.php" method="POST">
						<h3>Ricerca</h3> <br/>
						<p> Inserisci il nome del prodotto: &nbsp;&nbsp;&nbsp; <input type="text" name="prodotto"> </p> <br/>
						<input type="submit" name="bRicerca" id="bRicerca" value="Ricerca"> &nbsp;&nbsp;&nbsp; 
						<input type="button" id="torna" name="torna" value="HOME_PAGE" onClick="window.location.href ='index.php'">
					</form>
				</div>
			</div>
		</div>
	</div>
</body>
</html>