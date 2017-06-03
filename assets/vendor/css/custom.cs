/*****************************************************
	Custom CSS
/*****************************************************
/*****************************************************
/*****************************************************/



/*****************************************************
	General / Reset / Structure
/*****************************************************/

/* 1em = 10px; */
html { font-size: 62.5% !important; }
body { overflow-x:hidden; }

a { outline:none !important; font:inherit; }

.clearfix:after {
   content: " "; /* Older browser do not support empty content */
   visibility: hidden;
   display: block;
   height: 0;
   clear: both;
}

hr{border:1px solid white!important;margin-top:30px;}
#container { margin:0 auto; }

.hidden { display:none; }

h1,
h2 {
	font-family: 'Oswald', sans-serif; font-weight:700; font-size:3.5rem; line-height:60px;
	text-align:center; color:#FFF; text-transform:uppercase;
	background-color:#1460a6; margin:-30px auto -30px; max-width:515px;
	position:relative; z-index:50;
}
h1:before,
h1:after { content:" "; position:absolute;
	display:block; height:100%; width:60px; top:0;
	background-image:url(../images/graphics/losange-blue.png); background-size:100% 100%; background-repeat:no-repeat;
	z-index:-1;
}

h1:before { left:-30px; }
h1:after { right:-30px; }


h2 { margin:5px 0; background-color:transparent; max-width:none; color:#3ea934; }
h3,
h4 { font-family: 'Oswald', sans-serif; font-weight:700; font-size:2rem; line-height:1.2; text-transform:uppercase; margin-top:8px; margin-bottom:15px; color:#3ea934; }

h4 { font-size:1.8rem; font-weight:400; }

h5 { font-family: 'Oswald', sans-serif; font-size:1.4rem; font-weight:700; color:#abadb0; text-transform:uppercase; margin:15px 0; }

p,
td,
th { font-size:1.4rem; font-family: 'Roboto Condensed', sans-serif; margin-bottom:15px; line-height:1.3; color:#7e7c7c; }
th { font-weight:700; }


td, th { border:1px solid #cbcbcb; padding:8px 4px; }


/*****************************************************
	Header
/*****************************************************/
#menu-wrapper { background-color:rgba(0,0,0,0.3); }
#masthead { border-top:10px solid #3ea934; background-color:#FFF;
	-webkit-box-shadow: 0px 5px 5px 0px rgba(0, 0, 0, 0.4);
	-moz-box-shadow:    0px 5px 5px 0px rgba(0, 0, 0, 0.4);
	box-shadow:         0px 5px 5px 0px rgba(0, 0, 0, 0.4);
	position:relative; z-index:100;
}
.sticky { z-index:100000; }

/* Transitions */

.home-link,
#navbar {
	-webkit-transition:all 1s;
    transition:all 1s;
}
.nav-menu li a {
	-webkit-transition:all 0.5s;
    transition:all 0.5s;
}

.home-link {
	display:block; position:relative; z-index:10000;
	background-image:url(../images/Hydrosol_logo.png); background-size:auto 60%; background-repeat:no-repeat; background-position:left top 14px;
	height:130px;
}

#navbar { margin-top:64px; background-color:transparent; font-family: 'Oswald', sans-serif; text-transform:uppercase; }
#navbar ul { padding:0; }
.nav-menu li a {
    font-size: 1.9rem;
    color: #757575;
    padding: 17px 10px 11px 10px;
    font-weight: bold;
}

.nav-menu .current_page_item > a, .nav-menu .current_page_ancestor > a,
.nav-menu .current-menu-item > a, .nav-menu .current-menu-ancestor > a { color:#3ea934; }

/* Second Menu */
#secondNav { padding:0; margin-bottom:0; margin-top:75px; -webkit-transition:all 1s; transition:all 1s; }
#secondNav li {
    float: none;
    list-style: none;
    border-right: 1px solid #b6b8bb;
    text-align: right;
    display: inline-block;
}
#secondNav li img { max-width:24px; }
#secondNav li a {
	padding:0 6px;
	font-family: 'Oswald', sans-serif;
	font-size:1.4rem;
	color:#757575;
	text-transform:uppercase;
	-webkit-transition:all 0.5s;
    transition:all 0.5s;
}
#secondNav li#phone {
	display:block;
	text-align:right;
	border:none;
}
#secondNav li:last-child,
#secondNav li.social { border:none; }
#secondNav li a:hover { opacity:0.6; text-decoration:none; }

#secondNav li.social { margin-top:-2px; }

/* Sticky */
#masthead.sticky .home-link { height:73px; background-size:auto 60%; }
#masthead.sticky #navbar { margin-top:22px; }
#masthead.sticky #secondNav {
margin-top:15px;
display:block;
text-align:right;
 }



/* Images d'entetes */
#banner {
padding-bottom:300px; background-image:url(../images/bg-banner.jpg); background-repeat:no-repeat; background-size:cover; background-position:center center;
}


.symbol { text-align:center; margin-bottom:-45px !important; }
.symbol img { max-height:46px !important; }



/* Sous-menus */
.nav-menu .sub-menu {
	position:absolute; display:none; background-color:#ebebe6; border:none;
	margin-left:auto; margin-right:auto; left:-3000px; right:-5000px; top:47px;
	padding:20px 0 15px 3000px !important;
	-webkit-box-shadow: inset 0px 5px 5px 0px rgba(0, 0, 0, 0.4);
	-moz-box-shadow:    inset 0px 5px 5px 0px rgba(0, 0, 0, 0.4);
	box-shadow:         inset 0px 5px 5px 0px rgba(0, 0, 0, 0.4);
}

.nav-menu li:hover .sub-menu,
.nav-menu li:hover .sub-wrap:before { display:block; }
.nav-menu li:hover .sub-wrap { opacity:1; }
.sub-wrap {
	display:block;
	position:absolute; left:0; right:0; z-index:-1;
	-webkit-box-shadow: inset 0px 5px 5px 0px rgba(0, 0, 0, 0.4);
	-moz-box-shadow:    inset 0px 5px 5px 0px rgba(0, 0, 0, 0.4);
	box-shadow:         inset 0px 5px 5px 0px rgba(0, 0, 0, 0.4);
	background-color:#eeeeea;
	margin-top:26px; opacity:0;
	-webkit-transition:all 0.7s; transition:all 0.7s;
}
.sub-wrap:before { content:" "; position:absolute; display:none; background-color:#fff; width:100%; height:26px; top:-26px; }

.nav-menu li.menu-item-has-children:after { content:" "; display:block; opacity:0; width:100%; height:22px; background-image:url(../images/graphics/menu-arrow.png); background-size:0px 20px; bottom:-37px; position:absolute;
	background-position:center bottom; background-repeat:no-repeat;
}
.nav-menu li.menu-item-has-children:hover:after { opacity:1; background-size:19px 20px; -webkit-transition:all 0.7s; transition:all 0.7s; }

ul.nav-menu ul a,
.nav-menu ul ul a { color:#757575; }

.nav-menu .sub-menu li:hover > a,
.nav-menu .sub-menu li a:hover,
.nav-menu .sub-menu li:focus > a,
.nav-menu .sub-menu li a:focus { color:#1460a6; }

.nav-menu .sub-menu li { border-right:2px solid #7cbd75; }
.nav-menu .sub-menu li:last-child { border:none; }
.nav-menu .sub-menu li a { padding:0 15px; font-size:1.4rem; font-weight:400; font-family:'Oswald',sans-serif; }

.nav-menu .sub-menu .current_page_item > a,
.nav-menu .sub-menu .current_page_ancestor > a,
.nav-menu .sub-menu .current-menu-item > a,
.nav-menu .sub-menu .current-menu-ancestor > a { color:#1460a6; }

#masthead.sticky .sub-wrap { margin-top:7px; }
#masthead.sticky .sub-wrap:before { height:7px; top:-7px; }
#masthead.sticky .nav-menu li.menu-item-has-children:after { bottom:-12px; }


#header-bg { overflow:visible; }




/*****************************************************
	Home
/*****************************************************/
body.home p { font-weight:300; }

#twoButtons { border-top:7px solid #FFF; text-align:center; }
#twoButtons .c6 { padding:0 65px; }
.btSquare {
	position:relative;
	display:inline-block; background-color:#3ea934;
	line-height:35px; padding:0 14px; color:#FFF;
	margin-top:40px; margin-bottom:30px;
	font-family: 'Oswald', sans-serif; font-weight:400;
	text-transform:uppercase; font-size:1.8rem;
	-webkit-transition:all 0.5s; transition:all 0.5s;
}
.btSquare:before { content:" "; display:block; height:8px;
	position:absolute; top:-8px; left:0; right:0;
	background-image:url(../images/graphics/losange-green.png); background-position:top center; background-repeat:no-repeat;
}
.btSquare:hover { text-decoration:none; padding-right:20px; padding-left:20px; }


body.home #banner #header-bg > img:last-of-type {
	bottom: 65px;
    left: 0;
	right:0;
	max-width:239px;
	width:220px;
	margin:0 auto;
    position: absolute;

	-webkit-transition:all 0.5s; transition:all 0.5s;
}


/* Module News */
.info-module .c6 { padding:0 80px; }
.info-module .changer { text-align:center; }
.info-module .changer a { display:inline-block; background-color:transparent; height:10px; width:10px; border:1px solid #FFF; margin:0 5px;
	-webkit-border-radius: 5px;
	border-radius: 5px;
}
.info-module .changer a.active { background-color:#e87e23; }

#wrapper-news { position:relative; height: }
.news { position:absolute; top:0; left:0; right:0; opacity:0; -webkit-transition:all 0.7s; transition:all 0.7s; }
.news.active { opacity:1; }

.info-module input,
.info-module button { border:1px solid #FFF; box-sizing:border-box; float:left; }
#infolettre { width:80%; line-height:1.45; color:#000 !important; }
#send { color:#FFF; width:20%; background-color:#e87e23; border:none; border-left:2px solid #3ea934; text-transform:uppercase; font-family: 'Oswald', sans-serif; -webkit-transition:all 0.5s; transition:all 0.5s; }
#send:hover { opacity:0.7; }




/*****************************************************
	Contenu
/*****************************************************/
.entry-content { background-color:#efefea; }
.entry-content section { padding:30px 0; }
.entry-content > section:first-child { padding-top:45px; }
.entry-content section .c12 { padding:0 50px; }

.entry-content p a { font:inherit; font-weight:bold; font-style:italic; color:inherit; }
.entry-content ul li,
.entry-content ol li { font-size:1.4rem; font-family: 'Roboto Condensed', sans-serif; margin-bottom:15px; line-height:1.3; }

.basic h3,
.basic h4,
.basic h5,
.basic h6 { text-align:center; }

.pres p { color:#000; }

/*.basic p, .sectionImg p,
.basic a, .sectionImg a,
.basic td, .sectionImg td,
.basic th,  .sectionImg th { color:#7e7c7c; }*/

.basic,
.sectionImg { position:relative; }
.basic p { text-align:center; }

.sectionImg .c9 { padding-left:15px; }

.green:before,
.basic:before,
.sectionImg:before { content:" "; width:100%; height:11px; display:block;
	background-repeat:no-repeat; background-position:center bottom;
	position:absolute; top:0;
}
.green { position:relative; background-color:#3ea934; }
.green * { color:#efefea !important; }

.tableau td:first-child { width:200px; font-weight:700;font-size:16px; }

.basic:before,
.sectionImg:before { background-image:url(../images/graphics/losange-green.png); }
.green:before { background-image:url(../images/graphics/losange-beige.png); }

.entry-content .basic:first-of-type:before { display:none; }
.page-template-template-landings .entry-content .sectionImg:nth-of-type(2):before { display:none; }

/*****************************************************
	LANDINGS
/*****************************************************/
.landings * { color:#FFF; }
.landings .c4 { background-color:#3ea934; text-align:center; position:relative; border-bottom:10px solid #efefea; padding:30px 0; cursor:pointer; }
.landings .c4:before { content:" "; position:absolute; display:block; height:100%; top:0; left:-3000px; width:3000px; background-color:#3ea934; }
.landings .c4:after { content:" "; position:absolute; display:block; height:100%; top:0; right:-3000px; width:3000px; background-color:#3ea934; }

.landings .c4 .land-icon img { -webkit-transition: all 0.5s; transition: all 0.5s; }
.landings .c4:hover .land-icon img { opacity:0.7; }

.landings .c4 span { position:absolute; display:block; left:0; right:0; bottom:0; }
.landings .c4 span:after {
	content:" "; width:100%; height:7px; display:block;
	background-repeat:no-repeat; background-position:center top; background-image:url(../images/graphics/losange-beige.png);
	position:absolute; bottom:0;
}
/*.landings .c4:nth-child(1n+3) span { top:0; }
.landings .c4:nth-child(1n+3) span:after { top:0; background-position:center bottom; }*/

/*.landings .c4:nth-child(odd) { clear:left; border-right:5px solid #efefea; }
.landings .c4:nth-child(odd):after { display:none; }
.landings .c4:nth-child(even) { border-left:5px solid #efefea; }
.landings .c4:nth-child(even):before { display:none; }*/

.landings .c4:nth-child(even):before,
.landings .c4:nth-child(even):after,
.landings .c4:nth-child(1):after { display:none; }
.landings .c4:nth-of-type(even) { background-color:transparent; }
.landings .c4:nth-of-type(even) * { color:#757575; }

.landings .c4.blue,
.landings .c4.blue:after { background-color:#3ea934; /* #1460a6 */ }
.landings .c4.blue:before { display:none; background-color:#3ea934; }

.land-icon img { max-width:120px; height:auto; }

.plus { height:26px; width:26px; display:inline-block;
	margin-top:10px; margin-bottom:10px;
	background-image:url(../images/graphics/plus.png); background-size:cover; -webkit-transition:all 0.5s; transition:all 0.5s;
}
.landings .c4:nth-child(even) .plus { background-image:url(../images/graphics/plus-gris.png); }

.plus:hover { opacity:0.5; }
.enter-sub { margin-top:10px; display:block; text-transform:uppercase; font-family:'Oswald',sans-serif; font-weight:400; font-size:1.8rem; }

.page-template-template-landings .soumission { margin-bottom:-42px !important; margin-top:0px !important; }
.page-template-template-landings .soumission { -webkit-box-shadow: 0px 5px 4px 0px rgba(0, 0, 0, 0.36);
-moz-box-shadow:    0px 5px 4px 0px rgba(0, 0, 0, 0.36);
box-shadow:         0px 5px 4px 0px rgba(0, 0, 0, 0.36); }
.page-template-template-landings .soumission:after { background-image:url(../images/graphics/hack-right.png); background-size:auto 100%; background-position:center right; right:-16px; }
.page-template-template-landings .soumission:before { background-image:url(../images/graphics/hack-left.png); background-size:auto 100%; background-position:center left; left:-16px; }

.sm:hover { text-decoration:none; }



/*****************************************************
	RÃ©alisations
/*****************************************************/
#thumbs { padding-top:0; }

.thumb { padding:10px; }
.thumb a { position:relative; display:block; overflow:hidden; }
.thumb h3 { opacity:0; background-color:rgba(0,0,0,0.4); color:#FFF; margin:0; text-align:center;
	position:absolute; bottom:0; left:0; right:0;
	padding:15px 5px;
	-webkit-transition: all 0.5s;
    transition: all 0.5s;
}
.thumb a:hover h3 { opacity:1; }
.thumb figure {
	-webkit-transition: all 1s;
    transition: all 1s;
}
.thumb a:hover figure {
	-ms-transform: scale(1.3,1.3);
    -webkit-transform: scale(1.3,1.3);
    transform: scale(1.3,1.3);
}
.page-template-template-realisations .soumission { margin-top:5px; margin-bottom:35px; position:relative; text-align:center; }
.page-template-template-realisations .sList { margin-bottom:-10px; margin-top:50px; position:relative; z-index:10; }
.page-template-template-realisations .sList li { margin-bottom:0; }
.page-template-template-realisations .sList.empty { margin-top:40px; }

/* Colorbox */
#cboxContent { max-width:100%; }
#cboxLoadedContent { border:none; }
#cboxClose { background-image:none; background-color:#575758; top:0; right:0; width:30px; height:30px; background-image:url(../images/graphics/close.png);
	background-position:center center; background-size:40% 40%;
	-webkit-transition: all 0.5s; transition: all 0.5s;
}
#cboxClose:hover { background-position:center center; width:40px; height:40px; }

#cboxPrevious, #cboxNext { background-image:none; background-color:#e47f23; width:30px; height:80px;
	-webkit-transition: all 0.5s; transition: all 0.5s;
	background-size:auto 100%; background-position:center center;
}
#cboxPrevious:hover, #cboxNext:hover { width:50px; background-position:center center; }
#cboxPrevious { left:0; background-image:url(../images/graphics/arrowPrev.png); }
#cboxNext { right:0; background-image:url(../images/graphics/arrowNext.png); }

#cboxTitle { top:auto; bottom:0; left:0; right:0; background-color:rgba(0,0,0,0.4); }
#cboxTitle .c12 { padding:0 15px; }
#cboxTitle .c4 { width:36%; padding:9px 0; }
#cboxTitle .c8 { width:64%; }
#cboxTitle h2 { color:#FFF; line-height:42px;  }
#cboxTitle p { color:#fff; padding-left:10px; }

#cboxOverlay { background-color:#363636; }




/*****************************************************
	SERVICES
/*****************************************************/
.page-template-template-services .basic { padding-top:40px; }

.sList { text-align:center; padding:0; margin-top:15px; margin-bottom:25px; }
.sList li { display:inline-block; padding:0 10px; }
.sList a { font-family: 'Oswald', sans-serif; font-weight:400; font-size:1.8rem; text-transform:uppercase; color:#000; -webkit-transition: all 0.5s; transition: all 0.5s; }
.sList a:hover,
.sList a.current { text-decoration:none; color:#1460a6; }

.videos .c12 { padding-left:0 !important; padding-right:0 !important; }
.video { padding:0 20px; }
.video h2,
.video p { color:#1460a6; }
.video iframe { width:100% !important; }

.Lservice a { -webkit-transition: all 0.5s; transition: all 0.5s; }
.Lservice a:hover { opacity:0.6; text-decoration:none; }


/*****************************************************
	SINGLE
/*****************************************************/
.page-nouvelles .Lservice .c6 * { text-align:left; }
.single figure { text-align:center; }
.post-navigation { background-color:transparent; }

.post-navigation i { margin:0 10px; position:relative; -webkit-transition: all 0.5s; transition: all 0.5s; }
.post-navigation a { font-family: 'Oswald', sans-serif; font-style:normal; font-weight:400; font-size:1.4rem; color:#efefea; text-transform:uppercase; }
.post-navigation a:hover { color:#efefea; }
.post-navigation a[rel=prev]:hover i { opacity:0.6; margin-right:20px; margin-left:0px }
.post-navigation a[rel=next]:hover i { opacity:0.6; margin-right:0px; margin-left:20px }

.post-navigation a[rel="prev"] { float:left; }


/*****************************************************
	FAQ
/*****************************************************/
.question .more { cursor:pointer; -webkit-transition: all 0.5s; transition: all 0.5s;
	background-color:#3EA934;
	padding:5px 20px; -webkit-border-radius:3px; border-radius: 3px;
	color:#fff;
}
.question.turn i {
	-ms-transform: rotate(45deg);
    -webkit-transform: rotate(45deg);
    transform: rotate(45deg);
}
.question .more i { float:right; position:relative; top:3px; -webkit-transition: all 0.5s; transition: all 0.5s; }

.question .more:hover { /*opacity:0.7;*/ background-color:#1460A6; }
.question .reponse { padding:1px 20px; }

.basic .question p { text-align:left; }




/*****************************************************
	Contact
/*****************************************************/
.entry-content.contact .green { padding-bottom:0px; padding-top:40px; }

.wpcf7-form input,
.wpcf7-form textarea { color:#B8B7B0 !important; }
.wpcf7-form input[type=submit] { color:#FFF !important; }

div.wpcf7-response-output { margin-bottom:15px !important; }

.two-col-smaller p { font-size:1.3rem !important; }


/*****************************************************
	Footer
/*****************************************************/
#colophon { background-color:#FFF; }
#colophon a { color:#c4c6c8; }

#colophon .site-info { padding-bottom:70px; }

#colophon #fixedFoot { background-color:#E86811 !important; position:fixed; left:0; right:0; bottom:0; line-height:50px; color:#FFF; text-transform:uppercase; font-family:"Oswald",sans-serif; font-size:3.5rem; font-weight:700; line-height:60px;
	-webkit-transition: all 0.5s; transition: all 0.5s; z-index:99999999;
}
/*
#colophon #fixedFoot:hover { text-decoration:none; line-height:120px  !important }
*/

/* Leader module */
#taglines { position:relative; }
#leader { border-top:9px solid #3ea934; border-bottom:9px solid #3ea934; background-color:#efefea; position:relative; }
#leader h3 { opacity:0; font-size:4.8rem; color:#1460a6; text-transform:uppercase; font-family: 'Oswald', sans-serif; margin:0; line-height:2.8; font-weight:700; -webkit-transition: all 0.5s; transition: all 0.5s; position:absolute; width:100%; top:0; left:0; right:0; }

#leader h3.current { opacity:1; position:relative; }

#icons-pack { height:0px; overflow:visible; }
#icons-pack img { height:50px !important; margin-top:-30px; margin-right:6px; margin-left:6px; }
#icons-pack.bottom img { margin-top:0px; margin-bottom:-30px; }
#icons-pack a img { -webkit-transition: all 0.5s; transition: all 0.5s; position:relative; }
#icons-pack a:hover img,
#icons-pack a.current img {
	-ms-transform: scale(1.2,1.2);
    -webkit-transform: scale(1.2,1.2);
    transform: scale(1.2,1.2);
}


#gazon {
	background-image:url(../images/bg-footer.jpg); background-position:left bottom; background-repeat:repeat-x; background-size:730px auto;
	padding-top:35px; padding-bottom:100px;
}
#gazon a img:not([alt=icon-cochon]) { -webkit-transition: all 0.5s; transition: all 0.5s; }
#gazon a:hover img:not([alt=icon-cochon]) { opacity:0.7; }
/*#gazon .c3:nth-child(2) { border-right:1px solid #abadb0; }
#gazon .c3.right { border-left:1px solid #abadb0; }*/
#gazon h5 { text-align:center; margin-top:0; }
#gazon img { max-height:92px; }
#gazon img[alt=APPQ] { position:relative; z-index:100; }
/*#gazon img[alt=IECA] { margin-top:17px; }
#gazon img[alt=SCDC] { float:left; max-height:70px; margin:0; }
*/

.copyright { color:#c4c6c8; font-size:1.2rem; text-transform:uppercase; font-family: 'Oswald', sans-serif; line-height:1.2; margin-bottom:5px; }
.legal { color:#c4c6c8; font-size:1rem; line-height:1.2; margin-bottom:4px; }

#gazon img[alt=AMF] { margin:-12px 0 0 20px; }


/*#gazon .partenaires .c3 img:first-of-type {
	margin-left:20px;
}*/
/* Tagline Module */
#icons-pack {  }

.page-template-template-demande-php #fixedFoot { display:none; }



/*****************************************************
	Custom CSS Vince
/*****************************************************
/*****************************************************
/*****************************************************/


/************/
/*	HEADER	*/
/************/

body.home #banner
{
	padding-bottom:0px;
}
body.home #banner > .c12
{
	left: 360px;
    position: absolute;
    top: 160px;
}
body.home #banner .c12 > img
{
	left: 0;
    position: absolute;
    top: 0;
}
body.home #banner #header-bg
{
	position:relative;
}
body.home #banner #header-bg > img:first-child
{
	/*margin:0 auto;
	display:block;*/

	width:100%;
}

body.home #banner #header-bg > .c12
{
	position:absolute;
	top:0;
	left:0;
	right:0;
}
body.home #banner #header-bg > .c12:first-of-type {
	bottom:0%;
}
body.home #banner #header-bg > .c12:first-of-type a h1
{
	position:absolute;
    bottom:00px;
	z-index:10;
	max-width:inherit;
	width:41%;
	transition: all 0.5s ease 0s;
}
body.home #banner #header-bg > .c12:first-of-type a h1:hover
{
	width:43%;
}
body.home #banner #header-bg > .c12:first-of-type a:first-of-type h1
{
	right:54%;
	padding-right:35px;
}
body.home #banner #header-bg > .c12:first-of-type a:last-of-type h1
{
	left:54%;
	padding-left:35px;
}


/************/
/*	SERVICES	*/
/************/
body.page-template-template-services .entry-content section:last-child
{
	margin-bottom:35px;
}
body.page-template-template-services .entry-content .green:before
{
	display:none;
}
body.page-template-template-services .entry-content .green:after
{
	background-image: url("../images/graphics/losange-green.png");
    background-position: center bottom;
    background-repeat: no-repeat;
    content: " ";
    display: block;
    height: 11px;
    position: absolute;
    bottom:-11px;
    width: 100%;
}
body.page-template-template-services .entry-content .gris .c12 *
{
	color:#7e7c7c;
}
.entry-content .basic.Lservice .c5
{
	padding-left:100px;
}
.entry-content .basic.Lservice .c6
{
	margin:-18px 0 0 75px;
	padding-right:50px;
}
body.page-template-template-services .entry-content .basic .c6 h2,
body.page-template-template-services .entry-content .basic .c6 p
{
	text-align:left;
}
body.page-template-template-services .entry-content .basic > a
{
	text-decoration:none;
}
.entry-content .basic > a p
{
	position:relative;
	margin-top:50px;
	margin-bottom:-27px;
}


/************/
/*	CONTACT	*/
/************/
.contact .basic > div
{
	text-align:center;
	padding:0 140px;
}
.contact .basic > div > p:first-child
{
	margin:30px 0 23px;
}
.entry-content section .zoneForm
{
	font-family: 'Roboto Condensed', sans-serif;
	padding:0 140px;
}
.zoneForm > div:first-child
{
	font-size:1.4rem;
	padding-top:6px;
}
.entry-content .zoneForm > .c12 { padding:0; }
.zoneForm p
{
	color:#fff;
	text-align:left;
}
.zoneForm > div:first-child p:first-child
{
	margin:0;
}
.zoneForm > div:first-child strong
{
	font-size:1.8rem;
}
.zoneForm > div:first-child img
{
	float:left;
	margin:10px 15px 15px 0;

	transition: opacity .5s ease-out;
    -moz-transition: opacity .5s ease-out;
    -webkit-transition: opacity .5s ease-out;
    -o-transition: opacity .5s ease-out;
}
.zoneForm > div:first-child img:hover
{
	opacity:0.7;
}
.zoneForm form p
{
	float:left;
	width:100%;
}

.zoneForm form p input
{
	width:100%;
	font-weight:700;
	font-size:1.8rem;
	color:#000;
}
.zoneForm form p span span.wpcf7-not-valid-tip
{
	color:#fff;
	float:left;
}
.zoneForm form div textarea
{
	height:230px;
	border:none;
	resize: none;
	font-weight:700;
	font-size:1.8rem;
	color:#000;
}

.zoneForm form div p input
{
	border:none;
	padding:5px;
}

.zoneForm form > div:nth-child(2)
{
	padding-right:15px;
}

.zoneForm form > div:nth-child(3) p input
{
	background-color:#1460a6;
	color:#fff;
	font-family: 'Oswald', sans-serif;
	font-weight:400;
	padding: 3px 0 2px;
	line-height:29px;

	transition: opacity .5s ease-out;
    -moz-transition: opacity .5s ease-out;
    -webkit-transition: opacity .5s ease-out;
    -o-transition: opacity .5s ease-out;

}
.zoneForm form > div:nth-child(3) p input:hover
{
	opacity:0.7;
}
.zoneForm form > div:last-child
{
	float:left;
	width:100%;
	font-size:1.8rem;
	margin:0;
	border:2px solid #1460A6;
	background-color:rgba(0, 0, 0, 0.3);
}

/************/
/*	FOOTER	*/
/************/
#gazon > .c12
{
	position:relative;
}
#gazon .c12 > img:first-child
{
	bottom: -100px;
    height: inherit;
    left: 110px;
    max-height: inherit;
    max-width: inherit;
    position: absolute;
}
/*#gazon .c12 .c3:first-of-type
{
	padding-right:90px;
}*/
#gazon .c12 .c3:first-of-type img
{
	max-height:82px;
}
#gazon .c3.right{

	padding:2px 0 0 0;
	position:relative;
}
#gazon .c3.right h6 {
	margin-left:90px;
}
#gazon .c3.right > a:first-of-type
{
	position:absolute;
	left:50%;
	top:-50px;
}
#gazon .c12 > .c6 .c4:first-of-type
{
	padding-left:45px;
}
#gazon .c12 > .c6 .c4:last-of-type
{
	padding-right:20px;
}
#gazon div > div:last-child h5
{
	margin:15px 0 0;
	text-align:left;
}

#gazon img[alt="IECA"] {
    margin-top: 7px;
}
#gazon img
{
	max-height:72px;
}
h6
{
	color: #abadb0;
    font-family: "Oswald",sans-serif;
    font-size: 1.6rem;
    font-weight: 400;
    margin:0;
	text-align:left;
}
#gazon .partenaires {
	padding: 0 60px 0 80px;
}
#gazon .partenaires .c3 img{
	display:inline-block;
	vertical-align:middle;
	max-width:120px;
}
body.page-template-default footer #leader h3:before
{
	background-image: url("../images/graphics/losange-green.png");
    background-position: center bottom;
    background-repeat: no-repeat;
    content: " ";
    display: block;
    height: 11px;
    position: absolute;
    top: 0;
    width: 100%;
	z-index:1;
}
body.page-template-default footer #icons-pack img
{
	margin-top:-20px;
}


body.page-contact  footer #leader > a p
{
	display:none;
}


/************************/
/*	bouton SOUMISSION	*/
/************************/
.soumission
{
	display:none;

	background-color: #1460A6;
    color: #fff;
    font-family: "Oswald",sans-serif;
    font-size: 2.4rem;
    font-weight: 400;
    left: 0;
    margin: 0 auto;
    position: absolute;
    right: 0;
    text-transform: uppercase;
    top: -21px;
    width: 317px;
    z-index: 10;
	padding:5px 0;
	transition: all 0.5s ease 0s;
}
.soumission:hover {
	width: 327px;
}
.soumission:before,
.soumission:after
{
	background-image: url("../images/graphics/losange-blue.png");
    background-repeat: no-repeat;
    background-size: 70% 100%;
	content:" ";
	/*content: "â—¼";*/
    display: block;
	color:#1460A6;
    height: 100%;
    position: absolute !important;
    top:0px;
    width: 60px;
	font-size:3.2rem;
	z-index:-1;
}
.soumission:before
{
	left:-15px;
}
.soumission:after
{
	right:-30px;
}

/*NOUVEAU FORMULAIRE DE DEMANDE DE SOUMISSION: GRAVITY FORM*/
.gform_wrapper ul li.gfield.text-center {
	text-align:center !important;
}
.gform_wrapper .gfield.text-center.titre {
	margin:90px auto 30px auto;
}
.gform_wrapper input, .gform_wrapper textarea {
	border:none;
}
.gform_wrapper .top_label li.gfield {
	margin-bottom:10px !important;
}
.gform_wrapper label {
	    color: #7e7c7c !important;
}
.gform_wrapper ul li.gfield.titre .gfield_radio label {
	text-transform:uppercase;
	font-weight:bold;
	font-family:'Oswald', sans-serif;
	font-size:24px;
}
.gform_wrapper .top_label select.small {
    width: 40% !important;
}
.gform_wrapper .top_label li.gfield.gf_left_half input.small{
    width: 20% !important;
}
.gform_wrapper .icon .gfield_label {
	background:url(../images/pente_icon.png) no-repeat right center;
	background-size:30px;
	padding-right:35px;
	padding-top:5px;
}
.gform_wrapper .titre .ginput_container_radio label {
	color:#1460a6 !important;
}
.gform_wrapper .titre .ginput_container_radio ul li:last-of-type label {
	color:#3ea934 !important;
}
.gform_wrapper .titre .gfield_radio li input[type="radio"] {
	margin:11px 0 0 1px !important;
}
.gform_wrapper .gfield_radio li input[type="radio"] {
	margin-left:1px !important;
}
.gform_wrapper ul li.gfield.titre.color-accent {
	color:#1460a6;
}
.text-center {
	text-align:center;
}
.text-left, .basic .text-left {
	text-align:left;
	font-weight:bold;
}
.gform_wrapper .gfield_required {
    color: #7e7c7c !important;
}
.gform_wrapper li.gfield.gf_left_fourth, .gform_wrapper li.gfield.gf_right_fourth {
    display: -moz-inline-stack;
    display: inline-block;
    vertical-align: top;
}
.gform_wrapper li.gfield.gf_left_fourth {
    margin: 0 0 .5em 0;
    width: 22.5% !important;
		clear: left !important;
    margin-right: 2.5%;
}
.gform_wrapper li.gfield.gf_right_half.custom {
	margin-left:2.5% !important;
}
.gform_wrapper li.gfield.float {
	float:right;
}
.gform_wrapper li.gfield.gf_right_fourth.custom {
	width: 23% !important;
}

.gform_wrapper li.gfield.gf_right_fourth {
    clear: right !important;
		width: 22.5% !important;
}

.gform_wrapper .gform_button.button {
	background:#7e7c7c;
	text-transform:uppercase;
	color:#fff;
	font-weight:bold;
	font-size:18px !important;
	padding:4px 15px;
	font-family:'Oswald', sans-serif;
	letter-spacing:0.5px;
		-webkit-transition: background 0.2s ease-in;
	-moz-transition: background 0.2s ease-in;
	-ms-transition: background 0.2s ease-in;
	-o-transition: background 0.2s ease-in;
	transition: background 0.2s ease-in;
}
.gform_wrapper .gform_button.button:hover, .gform_wrapper .gform_button.button:focus {
	background:#1460a6;
}
.gform_footer.top_label {
	text-align:center !important;
}

select {
  -webkit-appearance: none;
  -webkit-border-radius: 0px;
	-moz-appearance:none;
}

.custom-select select {
	background:url(../images/carets-updown.png) no-repeat #FFF;
    background-position: 97% 50%;
    background-repeat: no-repeat;
   height: 29px;
   overflow: hidden;
   width: 240px;
	 background-size:9px 14px;
}
.custom-select select {
   border: none;
   font-size: 14px;
   height: 29px;
   padding: 5px 8px !important;
   width: 268px;
}
.gform_wrapper label {
	font-family:'Roboto', sans-serif;
}
.gform_wrapper h3 {
	color:#3ea934;
	margin-top:60px;
}
.gform_wrapper h3.color-accent {
	color:#1460a6;
}

/*STYLE POUR LE TABLEAU DE LA PAGE RESIDENTIEL/PRODUITS*/

section.basic.tableau table thead th {
	color:#1460a6;
	font-weight:700;
	font-size:16px;
}
section.basic.tableau table tbody td {
	color:#000;
}


@media all and (max-width:480px) {
	.gform_wrapper h3 {
    margin-top: 30px;
}
	.gform_wrapper li.gfield.gf_right_fourth {
		width: 100% !important;
}
.gform_wrapper .top_label select.small {
    width: 100% !important;
}
.gform_wrapper li.gfield.gf_left_fourth {
    width: 100% !important;
    margin-right: 0 !important;
}
.gform_wrapper .top_label li.gfield.gf_left_half {
    width: 100% !important;
		margin-right:0 !important
}
.gform_wrapper .top_label li.gfield.gf_right_half {
    width: 100% !important;
}
.gform_wrapper li.gfield.gf_right_fourth.custom {
    width: 100% !important;
}
.gform_wrapper li.gfield.gf_right_half.custom {
    margin-left: 0% !important;
}
.gform_wrapper .top_label li.gfield.gf_left_half textarea {
	width:100% !important;
}
.gform_wrapper .top_label li.gfield.gf_left_half input.large, .gform_wrapper .top_label li.gfield.gf_left_half input.medium, .gform_wrapper .top_label li.gfield.gf_left_half select.large, .gform_wrapper .top_label li.gfield.gf_left_half select.medium, .gform_wrapper .top_label li.gfield.gf_right_half input.large, .gform_wrapper .top_label li.gfield.gf_right_half input.medium, .gform_wrapper .top_label li.gfield.gf_right_half select.large, .gform_wrapper .top_label li.gfield.gf_right_half select.medium {
		width:100% !important;
}
.gform_wrapper .top_label input.large {
	width:100% !important;
}

}




/* Modifs DoubleV */
div.validation_error, div.gform_confirmation_message {
	font-size: 1.8em !important;
}
#secondNav li#phone a {
	font-size: 1.8em !important;
}
.zopim {
	margin-bottom: 60px !important;
}
@media all and (max-width:961px) {
	.zopim {
		margin-bottom: 45px !important;
	}
	#gazon .c3.right h6 {
	margin-left:0px;
}
}
@media all and (max-width:479px) {
	.zopim {
		margin-bottom: 35px !important;
	}
}
