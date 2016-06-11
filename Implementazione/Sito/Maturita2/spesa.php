				
<html>
	<head>
		<title>paginaRicerca</title>
		<link href="css/mioStileSpesa.css" rel="stylesheet">
		<link href="css/font-awesome.min.css" rel="stylesheet">
		<link href='http://fonts.googleapis.com/css?family=Lobster' rel='stylesheet' type='text/css'>
	</head>
<body>
	
	
	<div id="MIOdivRisultati" align="center" >
		<div class="container">
			<div class="row">
				<div class="section-title text-center">
					<h3>Lista della spesa</h3>
					
					<?php
							session_start(); 
							@include("connessione.php");
							
							$i = 1;
							$s = 0;
							//seleziono il database da usare
							mysqli_select_db($link, "data_frigo");
							
							$result1 = mysqli_query($link, "SELECT Nome FROM familiare WHERE IDFrigo = ( SELECT ID FROM frigo WHERE Username ='".$_SESSION["CodiceFrigo"]."')");
							
							
							if( mysqli_num_rows ( $result1 ) > 0)
							{
								
								//imposto la query
								$result = mysqli_query($link, "SELECT alimento.Nome FROM (alimento JOIN preferito ON IDAlimento = alimento.ID) JOIN familiare ON preferito.IDFamiliare = familiare.ID 
																WHERE  alimento.Nome NOT IN ( SELECT prodotto.NomeAlimento FROM prodotto WHERE 1) AND familiare.IDFrigo = ( SELECT ID FROM frigo WHERE Username ='".$_SESSION["CodiceFrigo"]."') ");
								
								
								
								
								$result2 = mysqli_query($link, "SELECT * FROM listaspesa WHERE IDFrigo = ( SELECT ID FROM frigo WHERE Username ='".$_SESSION["CodiceFrigo"]."')");
								
								
									
								if( mysqli_num_rows ( $result) > 0)
									$s = 0;
								else $s = 1;
								
								if( mysqli_num_rows ( $result2) > 0)
									$s = 0;
								
								
								if($s == 1)
									echo "</br></br>Tutti gli alimenti preferiti sono presenti nel frigo";
								else
								{
									echo "</br></br>";
									echo "<table align='center' >";
									echo "<tr><th>&nbsp;&nbsp; Num. &nbsp;&nbsp;</th><th>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Nome &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </th><th>&nbsp;&nbsp; Quantita' &nbsp;&nbsp;</th></tr>";
									
									while($row = mysqli_fetch_array( $result, MYSQL_BOTH)){
										echo "<tr><td align='center'>".$i."</td><td align='center'>".$row[0]."</td><td align='center'>"."-"."</td></tr>";
										$i++;
									}
								
									while($row = mysqli_fetch_array( $result2, MYSQL_BOTH)){
										echo "<tr><td align='center'>".$i."</td><td align='center'>".$row['nomeAlimento']."</td><td align='center'>".$row['quantita']."</td></tr>";
										$i++;
									}
								
							
									echo "</table>";
									
								}
								
							}else echo "</br></br>Nessun familiare registrato";
							
							?>
							
					</br></br> <input type="button" id="torna" name="torna" value="HOME PAGE" onClick="window.location.href ='index.php'"> </br></br>
				</div>
			</div>
		</div>
    </div>
	
	
</body>
</html>