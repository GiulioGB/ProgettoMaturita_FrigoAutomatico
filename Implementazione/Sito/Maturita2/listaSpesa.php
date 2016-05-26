<html>
	<head>
		<title>Lista della spesa</title>
		
		<!-- <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet"> -->

		<!-- mio stile -->
		<link href="css/mioStileSpesa.css" rel="stylesheet">
		
        <!-- Font Awesome CSS -->
        <link href="css/font-awesome.min.css" rel="stylesheet">
		
		<!-- Custom CSS -->
		<link href="css/animate.css" rel="stylesheet">

        <!-- Custom Fonts -->
        <link href='http://fonts.googleapis.com/css?family=Lobster' rel='stylesheet' type='text/css'>
		
		<?php session_start(); ?>
		<META HTTP-EQUIV="Refresh" CONTENT="5">
    </head>
	<body>
	<?php 
		//SE NON SONO PIU' CONNESSO NON POSSO VEDERE QUESTA PAGINA!!
		if(!isset($_SESSION["CodiceFrigo"]))
		{
			header("location: index.php");
		}
	?>
<!-- Inizio pagina di Inventario -->
		<div id="MIOdivInfo">	
			<div class="container">
				<div class="row">
					<div class="section-title text-center">
						<h3>Lista della spesa</h3>
						<?php
	
							@include("connessione.php");


							//seleziono il database da usare
							mysqli_select_db($link, "data_frigo");
							
							
							
							//imposto la query
							$result = mysqli_query($link, "SELECT Nome, dataScadenza , Barcode FROM prodotto WHERE IDFrigo = ( SELECT ID 
																													 FROM frigo
																													 WHERE Username ='".$_SESSION["CodiceFrigo"]."')");

							echo "</br></br>";
							echo "<table align='center' >";
							echo "<tr><th>&nbsp;&nbsp; Barcode &nbsp;&nbsp;</th><th> &nbsp;&nbsp; Nome &nbsp;&nbsp; </th><th> &nbsp;&nbsp; Data scadenza &nbsp;&nbsp;</th></tr>";
							while($row = mysqli_fetch_array( $result, MYSQL_BOTH)){
								echo "<tr><td align='center'>".$row["Barcode"]."</td><td align='center'>".$row["Nome"]."</td><td align='center'>".$row["dataScadenza"]."</td></tr>";
							}
							echo "</table>";
							echo "</br></br>";
							?>
							</br>
						</br>
						<input type="button" id="torna" name="torna" value="HOME PAGE" onClick="window.location.href ='index.php'">
						</br>
						</br>
					</div>
				</div>                                       
            </div>                		
		</div>
<!-- Fine della pagina di Inventario -->
	</body>
</html>