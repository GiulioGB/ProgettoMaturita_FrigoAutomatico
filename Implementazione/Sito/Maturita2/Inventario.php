<html>
	<head>
		<title>Inventario Frigo</title>
		
		<!-- <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet"> -->

		<!-- mio stile -->
		<link href="css/mioStile3.css" rel="stylesheet">
		
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
<!-- Inizio pagina di Inventario -->
		<div id="MIOdivInfo">	
			<div class="container">
				<div class="row">
					<div class="section-title text-center">
						<h3>Inventario Frigo</h3>
						<?php
	
							$link = mysqli_connect("localhost","root");

							if(mysqli_connect_errno()){
								printf("Connessione al server fallita", mysqli_connect_error());
								exit();
							} 


							//seleziono il database da usare
							mysqli_select_db($link, "prova2");

							//imposto la query
							$result = mysqli_query($link, "SELECT Nome, dataScadenza FROM prodotti");

							echo "</br>";
							echo "<table border='3' align='center' >";
							echo "<tr><td>Nome Prodotto</td><td>Data di Scadenza</td></tr>";
							while($row = mysqli_fetch_array( $result, MYSQL_BOTH)){

								echo "<tr>";
								echo "<td align='center'>$row[0]</td>";
								echo "<td align='center'>$row[1]</td>";
								echo "</tr>";
								
								
							}
							echo "</table>";
							
							?>
							</br>
						</br>
						<input type="button" id="torna" name="torna" value="HOME_PAGE" onClick="window.location.href ='index.php'">
						</br>
						</br>
					</div>
				</div>                                       
            </div>                		
		</div>
<!-- Fine della pagina di Inventario -->
	</body>
</html>