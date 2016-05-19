<html>
	<head>
		<title>Inventario Frigo</title>
		
		<!-- <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet"> -->

		<!-- mio stile -->
		<link href="css/mioStileFamiliari.css" rel="stylesheet">
		
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
		<div id="MIOdivFamiliari">	
			<div class="container">
				<div class="row">
					<div class="section-title text-center">
						<h3>Familiari registrati</h3>
						<?php
	
							@include("connessione.php");


							//seleziono il database da usare
							mysqli_select_db($link, "data_frigo");
							
							
							
							//imposto la query
							$result = mysqli_query($link, "SELECT Nome, Cognome , Sesso , Peso , Altezza , Eta   FROM familiare WHERE IDFrigo = 
							( SELECT ID 
							  FROM frigo
							  WHERE Username ='".$_SESSION["CodiceFrigo"]."')");
							
							
							if( mysqli_num_rows ( $result ) > 0)
							{
								echo "</br></br>";
								echo "<table align='center' >";
								echo "<tr><th> &nbsp;&nbsp; Nome &nbsp;&nbsp;</th><th> &nbsp;&nbsp; Cognome &nbsp;&nbsp;</th><th>Sesso</th><th> &nbsp;&nbsp; Peso &nbsp;&nbsp; </th><th> &nbsp;&nbsp; Altezza &nbsp;&nbsp; </th><th> &nbsp;&nbsp; Eta' &nbsp;&nbsp; </th></tr>";
								while($row = mysqli_fetch_array( $result, MYSQL_BOTH)){

									echo "<tr>";
									echo "<td align='center'>$row[0]</td>";
									echo "<td align='center'>$row[1]</td>";
									echo "<td align='center'>$row[2]</td>";
									echo "<td align='center'>$row[3]</td>";
									echo "<td align='center'>$row[4]</td>";
									echo "<td align='center'>$row[5]</td>";
									echo "</tr>";
									
									
								}
								echo "</table>";
								echo "</br></br>";
							
							} echo "Non ci sono familiari registrati"."</br></br>";
							
							?>
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