<html>
	<head>
		<title>LogIn</title>
		<?php session_start(); ?>
    </head>
	</head>
	<body>
<!-- Inizio pagina di Log-In -->
			<div class="section-modal modal fade" id="LogIn" tabindex="-1" role="dialog" aria-hidden="true">
				<div class="modal-content">
					<div class="close-modal" data-dismiss="modal">
						<div class="lr">
							<div class="rl">
							</div>
						</div>
					</div>
					
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
										echo "LOGN NON VALIDA ! Riprovare";
										
									}
									else if($_SESSION["ERRORE"] == 1)
									{
										echo "Login effettuata con successo! Torna pure alla HOME";
										
									}
									unset($_SESSION["ERRORE"]);
								?>
						   </div>
						</div>
					</div>    
				</div>
			</div>
<!-- Fine della pagina di Log-In -->
	</body>
</html>