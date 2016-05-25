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
							
							<form action="spesa.php" method="POST">
								<h3>Lista della spesa </h3> <br/>
								<p> Inserisci il nome dell'utente: &nbsp;&nbsp;&nbsp; <input type="text" name="utente"> </p> <br/>
								<input type="submit" name="bRicerca" id="bRicerca" value="Ricerca"> &nbsp;&nbsp;&nbsp; 
								<input type="button" id="torna" name="torna" value="HOME PAGE" onClick="window.location.href ='index.php'">
							</form>
							
						</br>
						</br>
					</div>
				</div>                                       
            </div>                		
		</div>
<!-- Fine della pagina di Inventario -->
	</body>
</html>