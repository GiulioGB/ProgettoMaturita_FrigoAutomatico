<!DOCTYPE html>
<html lang="en">

    <head>
		<?php session_start();  ?>
		
        <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <meta name="description" content="">
        <meta name="author" content="">

        <title>Frigo & Dispensa</title>

        <!-- Bootstrap Core CSS -->
        <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet">

        <!-- Font Awesome CSS -->
        <link href="css/font-awesome.min.css" rel="stylesheet">
		
		<!-- Custom CSS -->
        <link href="css/animate.css" rel="stylesheet"> 

        <!-- Custom CSS -->
        <link href="css/style.css" rel="stylesheet">

        <!-- Custom Fonts -->
        <link href='http://fonts.googleapis.com/css?family=Lobster' rel='stylesheet' type='text/css'>


        <!-- Template js -->
        <script src="js/jquery-2.1.1.min.js"></script>
        <script src="bootstrap/js/bootstrap.min.js"></script>
        <script src="js/jquery.appear.js"></script>
        <script src="js/contact_me.js"></script>
        <script src="js/jqBootstrapValidation.js"></script>
        <script src="js/modernizr.custom.js"></script>
        <script src="js/script.js"></script>

        <!--[if lt IE 9]>
            <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
            <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
        <![endif]-->

    </head>
    
    <body>
        
              
        
        <!-- Start Main Body Section -->
        <div class="mainbody-section text-center">
			<div class="container">
                <div class="row">
                    
                    <div class="col-md-3">
                        
                        <div class="menu-item blue">
							
                            <?php 
							if(isset($_SESSION["CodiceFrigo"]))
							{
								echo "<a href='Inventario.php' >";
								echo "<i class='fa fa-th-list'></i>";
								echo "<p>";
								echo "Inventario Frigo";
								echo "</p>";
								echo "</a>";
								
							}
							else
							{
								echo "<a href='' data-toggle='modal'>";
								echo "<i class='fa fa-ban'></i>";
								echo "<p>";
								echo "Funzione Riservata";
								echo "</p>";
								echo "</a>";
							}
							?>
							                     
                        </div>
                        
                        <div class="menu-item green">
						
						<?php 
							if(isset($_SESSION["CodiceFrigo"]))
							{
								echo "<a href='#RicercaF' data-toggle='modal'>";
								echo "<i class='fa fa-search'></i>";
								echo "<p>";
								echo "Ricerca prod. nel Frigo";
								echo "</p>";
								echo "</a>";
								
							}
							else
							{
								echo "<a href='' data-toggle='modal'>";
								echo "<i class='fa fa-ban'></i>";
								echo "<p>";
								echo "Funzione Riservata";
								echo "</p>";
								echo "</a>";
							}
						?>
                            
                        </div>
                        
                        <div class="menu-item light-red">
						<?php 
							if(isset($_SESSION["CodiceFrigo"]))
							{
								echo "<a href='#ListaS' data-toggle='modal'>";
								echo "<i class='fa fa-shopping-cart'></i>";
								echo "<p>";
								echo "Lista della spesa";
								echo "</p>";
								echo "</a>";
								
							}
							else
							{
								echo "<a href='' data-toggle='modal'>";
								echo "<i class='fa fa-ban'></i>";
								echo "<p>";
								echo "Funzione Riservata";
								echo "</p>";
								echo "</a>";
							}
						?>
                            
                        </div>
                        
                    </div>
                    
                    
                        
                        <div class="row">
                            <div class="col-md-3">
                                <div class="menu-item color responsive">
                                    <a href="LogIn.php">
                                        <i class="fa fa-unlock"></i>
                                        <p>
										<?php
											if(!isset($_SESSION["CodiceFrigo"]))
											{
												echo "Accedi";
											}											
											else
											{
												echo "Connesso come: ".$_SESSION["CodiceFrigo"];
											}
										?>
										</p>
                                    </a>
                                </div>
                            </div>
                            
                            <div class="col-md-3">
                                <div class="menu-item light-orange responsive-2">
                                    <a href="Out.php" >
                                        <i class="fa fa-lock"></i>
                                        <p>Log Out</p>
                                    </a>
                                </div>
                            </div>
                            
                        </div>
                        
                    </div>
                    
                    <div class="col-md-3">
                        
                        <div class="menu-item light-red">
						<?php 
							if(isset($_SESSION["CodiceFrigo"]))
							{
								echo "<a href='#InventarioD' data-toggle='modal'>";
								echo "<i class='fa fa-th-list'></i>";
								echo "<p>";
								echo "Inventario Frigo";
								echo "</p>";
								echo "</a>";
								
							}
							else
							{
								echo "<a href='' data-toggle='modal'>";
								echo "<i class='fa fa-ban'></i>";
								echo "<p>";
								echo "Funzione Riservata";
								echo "</p>";
								echo "</a>";
							}
						?>
                            
                        </div>
                        
                        <div class="menu-item color">
						<?php 
							if(isset($_SESSION["CodiceFrigo"]))
							{
								echo "<a href='#RicercaD' data-toggle='modal'>";
								echo "<i class='fa file-text'></i>";
								echo "<p>";
								echo "Ricerca prod. nella dispensa";
								echo "</p>";
								echo "</a>";
								
							}
							else
							{
								echo "<a href='' data-toggle='modal'>";
								echo "<i class='fa fa-ban'></i>";
								echo "<p>";
								echo "Funzione Riservata";
								echo "</p>";
								echo "</a>";
							}
						?>
                            
                        </div>
                        
                        <div class="menu-item blue">
                            <a href="Info.php" >
                                <i class="fa fa-info-circle"></i>
                                <p>Di cosa si tratta ?</p>
                            </a>
                        </div>
                        
                    </div>
                </div>
            </div>
        </div>
        <!-- End Main Body Section -->
        
        
        
    </body>
    
</html>