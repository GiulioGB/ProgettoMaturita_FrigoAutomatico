<html>
	<head>
		<title>LogIn</title>
		
		<!-- <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet"> -->

		<!-- mio stile -->
		<link href="css/mioStile.css" rel="stylesheet">
		
        <!-- Font Awesome CSS -->
        <link href="css/font-awesome.min.css" rel="stylesheet">
		
		<!-- Custom CSS -->
		<link href="css/animate.css" rel="stylesheet">

        <!-- Custom Fonts -->
        <link href='http://fonts.googleapis.com/css?family=Lobster' rel='stylesheet' type='text/css'>
		
		<?php session_start(); ?>
		
    </head>
	<body>
<!-- Inizio pagina di Log-In -->
			
			
			
			
		<div id="MIOdivLog">	
					<div class="container">
						<div class="row">
							<div class="section-title text-center">
								<h3>Accedi</h3>
								<p>Inserisci il codice del tuo frigo e la password che hai inserito al momento della sua accensione</p>
								<br/>
								<br/>
								
								<form action="salva.php" method="POST">
									<label>CODICE del frigo:&nbsp;&nbsp;&nbsp;<input type="Text" name="CodFrigo" id="CodFrigo" required/></label>
									<br/>
									<br/>
									<label>Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<input type="Password" name="Psw" id="Psw" required/></label>
									<br/>
									<br/>
									<input type="submit" id="submit" name="submit" value="Accedi"/>&nbsp;&nbsp;<input type="reset" id="reset" name="reset" value="Cancella">&nbsp;&nbsp;<input type="button" id="ritorna" name="ritorna" value="HOME_PAGE" onClick="window.location.href ='index.php'">
								</form>
								<br/>
								<br/>
								<?php 									
									if(!isset($_SESSION["ERRORE"]))
									{
										//unset($_SESSION["ERRORE"]);
									}
									else if($_SESSION["ERRORE"] == 0)
									{
										$message = "ERRORE! Password o Utente non corretta";
										echo "<SCRIPT> 
										alert('$message');
										</SCRIPT>";
									}
									//else if($_SESSION["ERRORE"] == 1)
									//{
										//echo "Login effettuata con successo! Torna pure alla HOME";
										
									//}
									unset($_SESSION["ERRORE"]);
								?>
						   </div>
						</div>
					</div>    
				</div>
<!-- Fine della pagina di Log-In -->
	</body>
</html>