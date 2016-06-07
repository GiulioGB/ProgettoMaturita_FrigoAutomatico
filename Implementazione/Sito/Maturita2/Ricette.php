<html>
	<head>
		<title>Ricette</title>
		
		<!-- <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet"> -->

		<!-- mio stile -->
		<link href="css/mioStileRicette.css" rel="stylesheet">
		
        <!-- Font Awesome CSS -->
        <link href="css/font-awesome.min.css" rel="stylesheet">
		
		<!-- Custom CSS -->
		<link href="css/animate.css" rel="stylesheet">

        <!-- Custom Fonts -->
        <link href='http://fonts.googleapis.com/css?family=Lobster' rel='stylesheet' type='text/css'>
		
		<?php session_start(); ?>
		
		<?php 
		//SE NON SONO PIU' CONNESSO NON POSSO VEDERE QUESTA PAGINA!!
		if(!isset($_SESSION["CodiceFrigo"]))
		{
			header("location: index.php");
		}
		?>
    </head>
	<body>
<!-- Inizio pagina di Inventario -->
		<div id="MIOdivRisultati">	
			<div class="container">
				<div class="row">
					<div class="section-title text-center">
						<h3>Ricette</h3>
						
						</br>
						
						&nbsp;&nbsp; <input type="image" id="gialloZafferano" name="gialloZafferano" src="images/LogoGialloZafferano.png" onClick="window.location.href ='http://www.giallozafferano.it/'"> &nbsp;&nbsp;
						&nbsp;&nbsp;<input type="image" id="salePepe" name="salePepe"  src="images/LogoCucinaItaliana.png" onClick="window.location.href ='http://www.lacucinaitaliana.it/'"> &nbsp;&nbsp;
						
						</br></br>
						
						&nbsp;&nbsp; <input type="image" id="cucinaItaliana" name="cucinaItaliana"  src="images/LogoSalePepe.png" onClick="window.location.href ='http://www.salepepe.it/'"> &nbsp;&nbsp;
						&nbsp;&nbsp;<input type="image" id="cockAround" name="cockAround" src="images/LogoCook.png" onClick="window.location.href ='http://www.cookaround.com/'"> &nbsp;&nbsp;
						
						</br></br></br></br>
						
						
						<input type="button" id="torna" name="torna" value="HOME PAGE" onClick="window.location.href ='index.php'">
						</br>
						</br>
					</div>
				</div>                                       
            </div>                		
		</div>
<!-- Fine della pagina Ricette -->
	</body>
</html>