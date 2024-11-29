<%@ Page Title="LandingPage" Language="C#" AutoEventWireup="true" CodeBehind="LandingPage.aspx.cs" Inherits="Front.LandingPage" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<%--<asp:content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">


</asp:content>--%>

<%--<!DOCTYPE html>--%>



<head>
    <meta charset="utf-8" />
    <meta content="width=device-width, initial-scale=1.0" name="viewport" />
    <title>Index - MyResume Bootstrap Template</title>
    <meta content="" name="description" />
    <meta content="" name="keywords" />
    <!-- Favicons -->
    <link href="assets/img/favicon.png" rel="icon" />
    <link href="assets/img/apple-touch-icon.png" rel="apple-touch-icon" />

    <!-- Fonts -->
    <link href="https://fonts.googleapis.com" rel="preconnect" />
    <link href="https://fonts.gstatic.com" rel="preconnect" />
    <link href="https://fonts.googleapis.com/css2?family=Roboto:ital,wght@0,100;0,300;0,400;0,500;0,700;0,900;1,100;1,300;1,400;1,500;1,700;1,900&family=Poppins:ital,wght@0,100;0,200;0,300;0,400;0,500;0,600;0,700;0,800;0,900;1,100;1,200;1,300;1,400;1,500;1,600;1,700;1,800;1,900&family=Raleway:ital,wght@0,100;0,200;0,300;0,400;0,500;0,600;0,700;0,800;0,900;1,100;1,200;1,300;1,400;1,500;1,600;1,700;1,800;1,900&display=swap" rel="stylesheet" />

    <!-- Vendor CSS Files -->
    <link href="assets/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="assets/vendor/bootstrap-icons/bootstrap-icons.css" rel="stylesheet" />
    <link href="assets/vendor/aos/aos.css" rel="stylesheet" />
    <link href="assets/vendor/glightbox/css/glightbox.min.css" rel="stylesheet" />
    <link href="assets/vendor/swiper/swiper-bundle.min.css" rel="stylesheet" />

    <!-- Main CSS File -->
    <link href="assets/css/main.css" rel="stylesheet" />

    <!-- =======================================================
  * Template Name: MyResume
  * Template URL: https://bootstrapmade.com/free-html-bootstrap-template-my-resume/
  * Updated: Jun 29 2024 with Bootstrap v5.3.3
  * Author: BootstrapMade.com
  * License: https://bootstrapmade.com/license/
  ======================================================== -->
</head>

<body class="index-page">

    <header id="header" class="header d-flex flex-column justify-content-center">

        <i class="header-toggle d-xl-none bi bi-list"></i>

        <nav id="navmenu" class="navmenu">
            <ul>

                <li><a href="LandingPage.aspx"><i class="bi bi-house navicon"></i><span>Contact</span></a></li>
            </ul>
        </nav>

    </header>

    <main class="main">
        <!-- Contact Section -->
        <section id="contact" class="contact section">

            <!-- Section Title -->
            <div class="container section-title" data-aos="fade-up">
                <h2>Inicio</h2>
                <p>Ingresa tus datos para continuar.</p>
            </div>
            <!-- End Section Title -->

            <div class="container" data-aos="fade" data-aos-delay="100">

                <div class="row gy-4">
                    <div class="col-lg-8">
                        <%--<form action="forms/contact.php" method="post" class="php-email-form" data-aos="fade-up" data-aos-delay="200">--%>
                        <form id="Master" runat="server" data-aos="fade-up" data-aos-delay="200">
                           <%-- class="php-email-form"  --%>
                            <div class="row gy-4">

                                <div class="col-md-6">
                                    <asp:TextBox ID="TxtName" runat="server" class="form-control" placeholder="Nombre"></asp:TextBox>
                                </div>

                                <div class="col-md-6 ">
                                    <asp:TextBox ID="TxtSName" runat="server" class="form-control" placeholder="Apellido"></asp:TextBox>
                                </div>

                                <div class="col-md-6 ">
                                    <asp:TextBox ID="TxtPhone" runat="server" class="form-control" placeholder="Telefono" TextMode="Phone" ToolTip="Numero almenos 8 digitos"></asp:TextBox>
                                </div>
                                <div class="col-md-6 ">
                                    <asp:TextBox ID="TxtAdress" runat="server" class="form-control" placeholder="Direccion"></asp:TextBox>
                                </div>
                                <div class="col-md-6 ">
                                    <asp:TextBox ID="TxtZipCode" Rows="2" runat="server" class="form-control" placeholder="Código Postal" TextMode="Number" ToolTip="Codigo de 5 digitos"></asp:TextBox>
                                </div>
                                <div class="col-md-6 ">
                                    <asp:ListBox runat="server" ID="LbCountry" SelectionMode="Single" class="form-control">
                                        <asp:ListItem Text="Guatemala" Value="0" Selected="True"></asp:ListItem>
                                        <asp:ListItem Text="El Salvador" Value="1"></asp:ListItem>
                                        <asp:ListItem Text="Mexico" Value="2"></asp:ListItem>
                                        <asp:ListItem Text="Costa Rica" Value="3"></asp:ListItem>
                                        <asp:ListItem Text="Panama" Value="4"></asp:ListItem>
                                    </asp:ListBox>
                                </div>
                                <div class="col-md-12">
                                    <asp:TextBox ID="TxtMail" runat="server" class="form-control" placeholder="Ejemplo@mail.com" TextMode="Email"></asp:TextBox>
                                </div>

                                <div class="col-md-12">
                                    <asp:TextBox ID="TxtMessage" runat="server" Rows="6" class="form-control" placeholder="Mensaje"></asp:TextBox>
                                </div>

                                <div class="col-md-12 text-center">
                                    <%--<div class="loading">Loading</div>
                                    <div class="error-message"></div>
                                    <div class="sent-message">Your message has been sent. Thank you!</div>--%>
                                    <asp:Button runat="server" ID="BtnSend" OnClick="BtnSend_Click" Text="Enviar" type="submit" class="btn btn-primary btn-lg" />
                                </div>
                            </div>
                        </form>
                    </div>
                    <!-- End Contact Form -->

                </div>

            </div>

        </section>
        <!-- /Contact Section -->

    </main>

    <footer id="footer" class="footer position-relative light-background">
        <div class="container">
            <h3 class="sitename">Edwin Barrios</h3>
            <p>Prueba tecnica FullStack Arista</p>

            <div class="container">
                <div class="credits">
                    <!-- All the links in the footer should remain intact. -->
                    <!-- You can delete the links only if you've purchased the pro version. -->
                    <!-- Licensing information: https://bootstrapmade.com/license/ -->
                    <!-- Purchase the pro version with working PHP/AJAX contact form: [buy-url] -->
                    Designed by <a href="https://bootstrapmade.com/">BootstrapMade</a> Distribuited by <a href="https://themewagon.com">ThemeWagon</a>
                </div>
            </div>
        </div>
    </footer>

    <!-- Scroll Top -->
    <a href="#" id="scroll-top" class="scroll-top d-flex align-items-center justify-content-center"><i class="bi bi-arrow-up-short"></i></a>

    <!-- Preloader -->
    <div id="preloader"></div>

    <!-- Vendor JS Files -->
    <script src="assets/vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    <script src="assets/vendor/aos/aos.js"></script>
    <script src="assets/vendor/typed.js/typed.umd.js"></script>
    <script src="assets/vendor/purecounter/purecounter_vanilla.js"></script>
    <script src="assets/vendor/waypoints/noframework.waypoints.js"></script>
    <script src="assets/vendor/glightbox/js/glightbox.min.js"></script>
    <script src="assets/vendor/imagesloaded/imagesloaded.pkgd.min.js"></script>
    <script src="assets/vendor/isotope-layout/isotope.pkgd.min.js"></script>
    <script src="assets/vendor/swiper/swiper-bundle.min.js"></script>

    <!-- Main JS File -->
    <script src="assets/js/main.js"></script>

</body>

</html>
