<html>
	<head>
		<link href="css/mioStileRicerca.css" rel="stylesheet">
		
		<title>PaginaDiRicerca</title>
		<?php session_start(); 
		?>
	</head>
<body>
	<div id="MIOdivRicerca">
		<form action="cerca.php" method="POST">
			<h3>Ricerca</h3> <br/>
			<p> Inserisci il nome del prodotto <input type="text" name="prodotto"> </p> <br/>
			<p> <input type="submit" name="bRicerca" id="bRicerca" value="Ricerca"> </p> <br/>
		</form>
    </div>
		
	<div id="divRisultati" align="center">
		
			<?php
			
			if($_SESSION['s'] == 0)
			{
			
			} else
			{	
				$vett = unserialize($_SESSION['result']);
				foreach($vett as $el)
					
			}
			
			
			?>
		
    </div>
</body>
</html>