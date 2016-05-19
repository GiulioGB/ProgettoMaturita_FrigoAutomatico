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
        
        <!-- Start Logo Section -->
        <section id="logo-section" class="text-center">
	        <div class="container">
                <div class="row">
                    <div class="col-md-12">
                        <div class="logo text-center">
                            <h1>Frigo & Dispensa</h1>
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
        
       
        
        
        <!-- Inizio pagina Ricerca nel Frigo -->
        <div class="section-modal modal fade" id="RicercaF" tabindex="-1" role="dialog" aria-hidden="true">
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
                            <h3>Ricerca</h3>
                            <p>Dopo aver scritto il nome del prodotto che desideri cercare all'interno del frigo, premi sul pulsante cerca</p>
                        </div>
                    </div>
                </div>
			</div>
		</div>
        <!-- Fine pagina Ricerca nel Frigo -->
        
        
        <!-- Inizio pagina Lista della Spesa -->
        <div class="section-modal modal fade" id="ListaS" tabindex="-1" role="dialog" aria-hidden="true">
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
                            <h3>Lista della spesa</h3>
                            <p>Qui di seguito la lista di tutti gli alimenti da comprare al più presto</p>
                        </div>
                    </div>
                </div>
			</div>
		</div>
        <!-- Fine pagina Lista della Spesa -->
                     
        
        <!-- Inizio pagina inventario nella dispensa -->
        <div class="section-modal modal fade" id="InventarioD" tabindex="-1" role="dialog" aria-hidden="true">
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
                            <h3>Inventario della dispensa</h3>
                            <p>Duis aute irure dolor in reprehenderit in voluptate</p>
                        </div>
                    </div>                 
                </div>                
            </div>
        </div>
        <!-- Fine pagina inventario nella dispensa -->
        
        
        
        <!-- Inizio pagina ricerca nella dispensa -->
        <div class="section-modal modal fade contact" id="RicercaD" tabindex="-1" role="dialog" aria-hidden="true">
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
                            <h3>Ricerca</h3>
                            <p>Dopo aver scritto il nome del prodotto che desideri cercare all'interno della dispensa, premi sul pulsante cerca</p>
                        </div>
                    </div>                  
                </div>                
            </div>
        </div>
        <!-- Fine pagina ricerca nella dispensa -->
        
        
         <!-- Inizio pagina Info -->
        <div class="section-modal modal fade contact" id="Info" tabindex="-1" role="dialog" aria-hidden="true">
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
                            <h3>Di cosa si tratta?</h3>
                            <p>
							<h4>Premessa</h4>
							Questo sito nasc come "supporto" al nostro SW raggiungibile al seguente link, e alla nostra applicazione disponibile per ora solo pr dispositivi Android raggiungibile tramite quest' altro link
							<h4>Cosa si può fare grazie a questo sito ?</h4>
							Funzioni semplici, ma che possono davero semplificare il modo con cui si è soliti "interagire" con frigo e dispensa di cui tutte le cucine sono provviste. Dimenticati di fogliettini e penna per segnarti ciò che devi comprare al supermercato, dimentica quella fastidiosa brina che i forma nelle calde giornate d' estate perchè hai aperto il frigo numerose volte per verificarne il contenuto
							<h4>Elenco funzioni</h4>
							<b>Visualizza contenuto del frigo: </b><br/>Tramite questa funzione sarà possibile visualizzare l'elenco di tutti gli alimenti contenuti nel frigo con tutti i relativi dettagli (es: nome,data di scadenza ... ).<br/>
							<b>Visualizza contenuto della dispensa: </b><br/>Tramite questa funzione sarà possibile visualizzare l'elendo di tutti gli alimenti contenuti nella dispensa con tutti i relativi dettagli (es: nome, data di scadenza...).<br/>
							<b>Ricerca prodotti nella dispensa: </b><br/>Tramite questa funzione sarà possibile ricercare un prodotto per Nome, così da verificarne la presenza o meno all' interno del frigo.<br/>
							<b>Ricerca prodotti nella dispensa: </b><br/>Tramite questa funzione sarà possibile ricercare un prodotto per Nome, così da verificarna la presenza o meno all' interno della dspensa.<br/>
							<b>Visualizzazione lista della spesa: </b><br/>"SE" un prodotto dovesse mancare o in frigo o nella dispensa sarà possibile aggiungerlo alla lista della spesa dal SW per poi visualizzarlo mentre si è al supermercato direttamente online.<br/>
							<h4>Piccoli accorgimenti</h4>
							Per garantire il corretto utilizzo delle funzioni, bisognerà prima di tutto effettuare la log-in utilizzando l' apposita sezione.
							</p>
                        </div>
                    </div>                                       
                </div>                
            </div>
        </div>
        <!-- Fine pagina Info -->
        
    </body>
    
</html>