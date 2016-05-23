<!DOCTYPE html>
<html lang="en">

    <head>
		<?php session_start();  ?>
		
        <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <meta name="description" content="">
        <meta name="author" content="">

        <title>Home page</title>

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
        
        <!-- Start Logo Section -->
        <section id="logo-section" class="text-center">
	        <div class="container">
                <div class="row">
                    <div class="col-md-12">
                        <div class="logo text-center">
                            <h1>Frigo Automatico</h1>
                            <span>Gestire il tutto in modo automatico SI PUO'</span>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- End Logo Section -->
        
        
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
								echo "<a href='ricerca.php' >";
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
								echo "<a href='listaSpesa.php'>";
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
                    
                    <div class="col-md-6">
                        
                        <!-- Start Carousel Section -->
                        <div class="home-slider">
                            <div id="carousel-example-generic" class="carousel slide" data-ride="carousel" style="padding-bottom: 30px;">
                                <!-- Indicators -->
                                <ol class="carousel-indicators">
                                    <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>
                                    <li data-target="#carousel-example-generic" data-slide-to="1"></li>
                                    <li data-target="#carousel-example-generic" data-slide-to="2"></li>
                                </ol>

                                <!-- Wrapper for slides -->
                                <div class="carousel-inner">
                                    <div class="item active">
                                        <img src="images/about-03.jpg" class="img-responsive" alt="">
                                    </div>
                                    <div class="item">
                                        <img src="images/about-02.jpg" class="img-responsive" alt="">
                                    </div>
                                    <div class="item">
                                        <img src="images/about-01.jpg" class="img-responsive" alt="">
                                    </div>

                                </div>

                            </div>
                        </div>
                        <!-- Start Carousel Section -->
                        
                        <div class="row">
                            <div class="col-md-6">
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
                            
                            <div class="col-md-6">
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
								echo "<a href='Familiari.php' >";
								echo "<i class='fa fa-users'></i>";
								echo "<p>";
								echo "Familiari";
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
        
        <!-- Start Copyright Section -->
        <div class="copyright text-center">
            <div class="container">
                <div class="row">
                    <div class="col-md-12">
                        <div>Design & Developed by <b>Shahriyar Ahmed</b> for GrayGrids&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
						Rieditato da <b>Ballabio Giulio</b> per progetto Maturità 2015/16</div>
                    </div>
                </div>
            </div>
        </div>
        <!-- End Copyright Section -->
        
        
    </body>
    
</html>