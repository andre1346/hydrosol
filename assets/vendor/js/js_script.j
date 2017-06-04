$(function(){


	// remove les liens tel:
	if( !(/Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent)) ) {
		$('a[href^="tel:"]').each(function(){
			//$(this);
		});
	}

	// Menumobile
	$('#mmenu').mmenu({
		"slidingSubmenus": false,
		"offCanvas": {
			"position": "right",
			"zposition": "front"
		},
		"extensions": [
			"theme-white"
		]
	});



	////////////////////
	// Scroll and sticky menu
	////////////////////
	setWrapper();
	$(window).resize(function(){
		setWrapper();
		adjustWrapperNews();
		adjustLandingsBlock();
	});

	function setWrapper(){
		$('#menu-wrapper').height($('#masthead').outerHeight());
	}


	var oldPos = 0;
	$(window).scroll(function(){
		var wrapperPos = $('#menu-wrapper').offset().top;
		var bottomMenu = $('#menu-wrapper').offset().top + $('#masthead').outerHeight();
		var h = $('#masthead').outerHeight();

		if( /Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent) ) {
			// Si ont dÃ©pace le bas menu
			if($(this).scrollTop() > bottomMenu){
				if(!$('#masthead').hasClass('fixx')){
					$('#masthead').css({
						'position': 'fixed',
						'left': 0,
						'right': 0,
						'top': -h
					}).addClass('fixx');
				}

				// if scroll vers le haut
				if(oldPos > $(this).scrollTop()){
					dropMobileHeader();
				}else{
					closeMobileHeader(h);
					console.log('close');
				}
			}else if($(this).scrollTop() <= wrapperPos){
				$('#masthead').finish().css({
					'position': 'relative',
					'top': '0'
				}).removeClass('fixx');;
			}
		}else{
			// Si l'on veut qu'il soit sticky sur la version desctop Ã©galement
			/*if($('body.home').length > 0){	// si l'accueil

				if($(this).scrollTop() > wrapperPos){
					if($('#masthead').hasClass('sticky')){
						$('#masthead').css({
							'position': 'fixed',
							'left': 0,
							'right': 0,
							'top': 0
						});
					}
					if($(this).scrollTop() > wrapperPos + 50){
						if(!$('#masthead').hasClass('sticky')){
							$('#masthead').addClass('sticky');
						}
					}

					if($(this).scrollTop() <= wrapperPos + 50){
						$('#masthead').removeClass('sticky');
					}

				}else if($(this).scrollTop() <= wrapperPos){
					$('#masthead').finish().css({
						'position': 'relative',
						'top': '0'
					})
				}
			}else{// if home
				if($(this).scrollTop() > wrapperPos){
					if(!$('#masthead').hasClass('sticky')){
						$('#masthead').css({
							'position': 'fixed',
							'left': 0,
							'right': 0,
							'top': 0
						});
					}
				}
			}*/
		}// if mobile

		// Set le derniere position
		oldPos = $(this).scrollTop();
	});// scroll


	// fait dÃ©scendre la barre du menu si elle n'est pas dÃ©scendu
	function dropMobileHeader(){
		console.log('drop');
		if(!$('#masthead').hasClass('opened')){
			$('#masthead').stop().animate({top : 0}, 300).addClass('opened');
		}
	}// function

	// fait monter la barre du menu si elle n'est pas montÃ©
	function closeMobileHeader(h){
		if($('#masthead').hasClass('opened')){
			$('#masthead').stop().animate({top : -h}, 300).removeClass('opened');
		}
	}// function


	// Helper sub-menu
	//$('.mm-page .sub-menu').wrap('<span class="sub-wrap"></span>');




	////////////////////
	// News Module
	////////////////////
	/* GÃ©nÃ¨re les boutons */
	$('#wrapper-news .news').each(function(){
		var index = $(this).index();
		if(index==0){
			$('.info-module .changer').append('<a href="'+index+'" class="active"></a>');
		}else{
			$('.info-module .changer').append('<a href="'+index+'"></a>');
		}
	});

	// Click Event
	$('.info-module .changer a').click(function(e){
		e.preventDefault();
		$('.info-module .changer a').removeClass('active');
		$(this).addClass('active');
		var i = $(this).index();
		$('#wrapper-news .news').removeClass('active').eq(i).addClass('active');
	});

	// Ajuste la hauteur du wrapper de nouvelle Ã  la plus haute nouvelle
	function adjustWrapperNews(){
		$('#wrapper-news .news').each(function(){
			var h = 0;
			if(h < $(this).height()){h = $(this).height();}
			$('#wrapper-news').height(h+20);
		});
	}// function


	// Ajuste la hauteur des blocks des pages Landings
	function adjustLandingsBlock(){
		$('.landings .c4').each(function(){
			var h = 0;
			if(h < $(this).height()){h = $(this).height();}
			$('.landings .c4').height(h);
		});
	}// function



	////////////////////
	// Tag selectors rÃ©alisations
	////////////////////
	$('.page-template-template-realisations .sList a').click(function(e){
		e.preventDefault();
		$('.page-template-template-realisations .sList a').removeClass('current');
		$(this).addClass('current');
		if($(this).attr('href') == '#'){
			$('#thumbs .thumb').fadeIn(300);
		}else{
			$('#thumbs .thumb').fadeOut(300);
			$('#thumbs .thumb[data-terms~="'+$(this).attr('href')+'"]').fadeIn(300);
		}
	});



	////////////////////
	// Colorbox
	////////////////////
	$(".RealisationsGroup").colorbox({
		rel:'RealisationsGroup',
		transition:"fade",
		//maxWidth: 1200,
		maxWidth:'95%',
		maxHeight:'95%',
		scalePhotos: true,
		scrolling: false,
		current:'',
		opacity: 0.7,
		title: function(){
			var out = '<div class="c12">';
				out += '<div class="c4">';
					out += '<h2>'+$(this).find('h3').text()+'</h2>';
				out += '</div>';
				out += '<div class="c8">';
					out += '<p>'+$(this).data('content')+'</p>';
				out += '</div>';
			out += '</div>';
			return out;
		}
	});




	////////
	// TOGGLE FAQ
	///////
	$('.question .reponse').toggle();
	$('.question .more').click(function(e){
		e.preventDefault();
		if($(this).closest('.question').find('.reponse').hasClass('opened')){
			$(this).closest('.question').removeClass('turn');
			$('.opened').removeClass('opened').stop().slideToggle( 500 );
		}else{
			$('.question').removeClass('turn');
			$(this).closest('.question').addClass('turn');
			$('.opened').removeClass('opened').slideToggle( 500 );
			$(this).closest('.question').find('.reponse').addClass('opened').stop().slideToggle( 500 );
		}
	});


	$(window).load(function(){
		adjustLandingsBlock();
		adjustWrapperNews();
	});

	//// Taglines footer
	$('#icons-pack a').click(function(e){
		e.preventDefault();
		$('#icons-pack a').removeClass('current');
		$(this).addClass('current');

		$('#taglines h3').removeClass('current');
		$('#taglines h3:nth-child('+($(this).index() + 1)+')').addClass('current');
	});

	setInterval(function(){
		var index = $('#taglines h3.current').index();
		$('#taglines h3, #icons-pack a').removeClass('current');
		if(index == 2){ index = -1 }
		$('#taglines h3:nth-child('+(index + 2)+')').addClass('current');
		$('#icons-pack a:nth-child('+(index + 2)+')').addClass('current');
	}, 3000);


	//// landings hitzones
	$('.landings .c4').click(function(e){
		e.preventDefault();
		window.location.href = $(this).find('.enter-sub').attr('href');
	});


});
