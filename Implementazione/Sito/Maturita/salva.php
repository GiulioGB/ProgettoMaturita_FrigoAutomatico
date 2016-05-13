<html>
	<head>
		<title>PaginaDiCONTROLLOeSALVATAGGIO</title>
		<?php session_start(); ?>
	</head>
<body>
	<?php
	//leggo NomeFrigo e Password
	$nome = $_POST["CodFrigo"];
	$password = $_POST["Psw"];
	
	//apro il file e lo "butto" in un vettore appena creato
	$vettoreFrigo = Array();
	$vettoreFrigo = file("FRIGO.txt");
	
	//verifica
	//conto quanti elementi ci sono nel vettore 
	$TotElem = count($vettoreFrigo);
	
	//setto una sentinella
	$sentinella = 0;
	$indice2 = 1;
	for($i=0;$i<$TotElem;$i+=2)
	{
		if(($nome == trim($vettoreFrigo[$i])) && ($password = trim($vettoreFrigo[$indice2])))
		{
			echo "ok";
			$sentinella = 1;
		}
		else
		{
			//echo "no ";
			//echo $nome." diverso da ".$vettoreFrigo[$i];
			//echo "indice ".$i;
		}
		//echo $sentinella;
		$_SESSION["ERRORE"]=1;
		
		$s = true;
		
		if( $sentinella == 1)
		{
			echo "stai per uscire da ciclo";
			//break;
			//setto la variabile di sessione
			$_SESSION["CodiceFrigo"] = $nome;
			$_SESSION["ERRORE"] = $sentinella;
			header("location: index.php");
			//break;
		}
		else
		{
			$_SESSION["ERRORE"] = $sentinella;
			header("location: LogIn.php");
			
		}
		$indice2 +=2 ;
	}
	
	?>
</body>
</html>