/*
Theme Name: Hydrosol
Author: Codems
*/


/**
 * Table of Contents:
 *
 * 1.0 - Reset
 * 2.0 - Repeatable Patterns
 * 3.0 - Basic Structure
 * 4.0 - Header
 *   4.1 - Site Header
 *   4.2 - Navigation
 * 5.0 - Content
 *   5.1 - Entry Header
 *   5.2 - Entry Meta
 *   5.3 - Entry Content
 *   5.4 - Galleries
 *   5.5 - Post Formats
 *   5.6 - Attachments
 *   5.7 - Post/Paging Navigation
 *   5.8 - Author Bio
 *   5.9 - Archives
 *   5.10 - Search Results/No posts
 *   5.11 - 404
 *   5.12 - Comments
 *   5.13 - Multisite
 * 6.0 - Sidebar
 *   6.1 - Widgets
 * 7.0 - Footer
 * 8.0 - Media Queries
 * 9.0 - Print
 * ----------------------------------------------------------------------------
 */


/**
 * 1.0 Reset
 *
 * Modified from Normalize.css to provide cross-browser consistency and a smart
 * default styling of HTML elements.
 *
 * @see http://git.io/normalize
 * ----------------------------------------------------------------------------
 */

* {
	-webkit-box-sizing: border-box;
	-moz-box-sizing:    border-box;
	box-sizing:         border-box;
}

article,
aside,
details,
figcaption,
figure,
footer,
header,
nav,
section,
summary {
	display: block;
}

audio,
canvas,
video {
	display: inline-block;
}

audio:not([controls]) {
	display: none;
	height: 0;
}

[hidden] {
	display: none;
}

html {
	font-size: 100%;
	overflow-y: scroll;
	-webkit-text-size-adjust: 100%;
	-ms-text-size-adjust: 100%;
}

html,
button,
input,
select,
textarea {
	font-family: "Source Sans Pro", Helvetica, sans-serif;
}

body {
	color: #141412;
	line-height: 1.5;
	margin: 0;
}

a {
	text-decoration: none;
}

a:active,
a:hover {
	outline: 0;
}

a:hover {
	text-decoration: underline;
}

h1,
h2,
h3,
h4,
h5,
h6 {
	clear: both;
	font-family: Bitter, Georgia, serif;
	line-height: 1.3;
}

h1 {
	font-size: 48px;
	margin: 33px 0;
}

h2 {
	font-size: 30px;
	margin: 25px 0;
}

h3 {
	font-size: 22px;
	margin: 22px 0;
}

h4 {
	font-size: 20px;
	margin: 25px 0;
}

h5 {
	font-size: 18px;
	margin: 30px 0;
}

h6 {
	font-size: 16px;
	margin: 36px 0;
}

address {
	font-style: italic;
	margin: 0 0 24px;
}

abbr[title] {
	border-bottom: 1px dotted;
}

b,
strong {
	font-weight: bold;
}

dfn {
	font-style: italic;
}

mark {
	background: #ff0;
	color: #000;
}

p {
	margin: 0 0 24px;
}

code,
kbd,
pre,
samp {
	font-family: monospace, serif;
	font-size: 14px;
	-webkit-hyphens: none;
	-moz-hyphens:    none;
	-ms-hyphens:     none;
	hyphens:         none;
}

pre {
	background: #f5f5f5;
	color: #666;
	font-family: monospace;
	font-size: 14px;
	margin: 20px 0;
	overflow: auto;
	padding: 20px;
	white-space: pre;
	white-space: pre-wrap;
	word-wrap: break-word;
}

blockquote,
q {
	-webkit-hyphens: none;
	-moz-hyphens:    none;
	-ms-hyphens:     none;
	hyphens:         none;
	quotes: none;
}

blockquote:before,
blockquote:after,
q:before,
q:after {
	content: "";
	content: none;
}

blockquote {
	font-size: 18px;
	font-style: italic;
	font-weight: 300;
	margin: 24px 40px;
}

blockquote blockquote {
	margin-right: 0;
}

blockquote cite,
blockquote small {
	font-size: 14px;
	font-weight: normal;
	text-transform: uppercase;
}

blockquote em,
blockquote i {
	font-style: normal;
	font-weight: 300;
}

blockquote strong,
blockquote b {
	font-weight: 400;
}

small {
	font-size: smaller;
}

sub,
sup {
	font-size: 75%;
	line-height: 0;
	position: relative;
	vertical-align: baseline;
}

sup {
	top: -0.5em;
}

sub {
	bottom: -0.25em;
}

dl {
	margin: 0 20px;
}

dt {
	font-weight: bold;
}

dd {
	margin: 0 0 20px;
}

menu,
ol,
ul {
	margin: 16px 0;
	padding: 0 0 0 40px;
}

ul {
	list-style-type: square;
}

nav ul,
nav ol {
	list-style: none;
	list-style-image: none;
}

li > ul,
li > ol {
	margin: 0;
}

img {
	-ms-interpolation-mode: bicubic;
	border: 0;
	vertical-align: middle;
}

svg:not(:root) {
	overflow: hidden;
}

figure {
	margin: 0;
}

form {
	margin: 0;
}

fieldset {
	border: 1px solid #c0c0c0;
	margin: 0 2px;
	padding: 0.35em 0.625em 0.75em;
}

legend {
	border: 0;
	padding: 0;
	white-space: normal;
}

button,
input,
select,
textarea {
	font-size: 100%;
	margin: 0;
	max-width: 100%;
	vertical-align: baseline;
}

button,
input {
	line-height: normal;
}

button,
html input[type="button"],
input[type="reset"],
input[type="submit"] {
	-webkit-appearance: button;
	cursor: pointer;
}

button[disabled],
input[disabled] {
	cursor: default;
}

input[type="checkbox"],
input[type="radio"] {
	padding: 0;
}

input[type="search"] {
	-webkit-appearance: textfield;
	padding-right: 2px; /* Don't cut off the webkit search cancel button */
	width: 270px;
}

input[type="search"]::-webkit-search-decoration {
	-webkit-appearance: none;
}

button::-moz-focus-inner,
input::-moz-focus-inner {
	border: 0;
	padding: 0;
}

textarea {
	overflow: auto;
	vertical-align: top;
}

table {
	border-bottom: 1px solid #ededed;
	border-collapse: collapse;
	border-spacing: 0;
	font-size: 14px;
	line-height: 2;
	margin: 0 0 20px;
	width: 100%;
}

caption,
th,
td {
	font-weight: normal;
	text-align: left;
}

caption {
	font-size: 16px;
	margin: 20px 0;
}

th {
	font-weight: bold;
	text-transform: uppercase;
}

td {
	border-top: 1px solid #ededed;
	padding: 6px 10px 6px 0;
}

del {
	color: #333;
}

ins {
	background: #fff9c0;
	text-decoration: none;
}

hr {
	border: 1px solid #000;
	height: 1px;
	margin: 0 0 24px;
}


/**
 * 2.0 Repeatable Patterns
 * ----------------------------------------------------------------------------
 */

.genericon:before,
.menu-toggle:after,
.featured-post:before,
.date a:before,
.entry-meta .author a:before,
.format-audio .entry-content:before,
.comments-link a:before,
.tags-links a:first-child:before,
.categories-links a:first-child:before,
.edit-link a:before,
.attachment .entry-title:before,
.attachment-meta:before,
.attachment-meta a:before,
.comment-awaiting-moderation:before,
.comment-reply-link:before,
.comment-reply-login:before,
.comment-reply-title small a:before,
.bypostauthor > .comment-body .fn:before,
.error404 .page-title:before {
	-webkit-font-smoothing: antialiased;
	display: inline-block;
	font: normal 16px/1 Genericons;
	vertical-align: text-bottom;
}

/* Clearing floats */
.clear:after,
.attachment .entry-header:after,
.site-footer .widget-area:after,
.entry-content:after,
.page-content:after,
.navigation:after,
.nav-links:after,
.gallery:after,
.comment-form-author:after,
.comment-form-email:after,
.comment-form-url:after,
.comment-body:after {
	clear: both;
}

.clear:before,
.clear:after,
.attachment .entry-header:before,
.attachment .entry-header:after,
.site-footer .widget-area:before,
.site-footer .widget-area:after,
.entry-content:before,
.entry-content:after,
.page-content:before,
.page-content:after,
.navigation:before,
.navigation:after,
.nav-links:before,
.nav-links:after,
.gallery:before,
.gallery:after,
.comment-form-author:before,
.comment-form-author:after,
.comment-form-email:before,
.comment-form-email:after,
.comment-form-url:before,
.comment-form-url:after,
.comment-body:before,
.comment-body:after {
	content: "";
	display: table;
}

/* Assistive text */
.screen-reader-text {
	clip: rect(1px, 1px, 1px, 1px);
	position: absolute !important;
}

.screen-reader-text:focus {
	background-color: #f1f1f1;
	border-radius: 3px;
	box-shadow: 0 0 2px 2px rgba(0, 0, 0, 0.6);
	clip: auto !important;
	color: #21759b;
	display: block;
	font-size: 14px;
	font-weight: bold;
	height: auto;
	line-height: normal;
	padding: 15px 23px 14px;
	position: absolute;
	left: 5px;
	top: 5px;
	text-decoration: none;
	width: auto;
	z-index: 100000; /* Above WP toolbar */
}

/* Form fields, general styles first. */
button,
input,
textarea {
	border: 2px solid #d4d0ba;
	font-family: inherit;
	padding: 5px;
}

input,
textarea {
	color: #141412;
}

input:focus,
textarea:focus {
	border: 2px solid #c3c0ab;
	outline: 0;
}

.post-password-required input[type="submit"] {
	padding: 7px 24px 4px;
	vertical-align: bottom;
}

.post-password-required input[type="submit"]:active {
	padding: 5px 24px 6px;
}

/* Placeholder text color -- selectors need to be separate to work. */
::-webkit-input-placeholder {
	color: #7d7b6d;
}

:-moz-placeholder {
	color: #7d7b6d;
}

::-moz-placeholder {
	color: #7d7b6d;
}

:-ms-input-placeholder {
	color: #7d7b6d;
}

/*
 * Responsive images
 */
img {
	width:auto;
	height:auto;
	max-width: 100%;
}

/* Make sure videos and embeds fit their containers. */
embed,
iframe,
object,
video {
	max-width: 100%;
}

/* Override the Twitter embed fixed width. */
.entry-content .twitter-tweet-rendered {
	max-width: 100% !important;
}

/* Images */
.alignleft {
	float: left;
}

.alignright {
	float: right;
}

.aligncenter {
	display: block;
	margin-left: auto;
	margin-right: auto;
}

figure.wp-caption.alignleft,
img.alignleft {
	margin: 5px 20px 5px 0;
}

.wp-caption.alignleft {
	margin: 5px 10px 5px 0;
}

figure.wp-caption.alignright,
img.alignright {
	margin: 5px 0 5px 20px;
}

.wp-caption.alignright {
	margin: 5px 0 5px 10px;
}

img.aligncenter {
	margin: 5px auto;
}

img.alignnone {
	margin: 5px 0;
}

.wp-caption .wp-caption-text,
.entry-caption,
.gallery-caption {
	color: #220e10;
	font-size: 18px;
	font-style: italic;
	font-weight: 300;
	margin: 0 0 24px;
}

div.wp-caption.alignright img[class*="wp-image-"] {
	float: right;
}

div.wp-caption.alignright .wp-caption-text {
	padding-left: 10px;
}

img.wp-smiley,
.rsswidget img {
	border: 0;
	border-radius: 0;
	box-shadow: none;
	margin-bottom: 0;
	margin-top: 0;
	padding: 0;
}

.wp-caption.alignleft + ul,
.wp-caption.alignleft + ol {
	list-style-position: inside;
}


/**
 * 3.0 Basic Structure
 * ----------------------------------------------------------------------------
 */

.site {
	background-color: #fff;	margin: 0 auto;
	width: 100%;
}

.site-main {
	position: relative;
}

.site-main .sidebar-container {
	height: 0;
	position: absolute;
	top: 40px;
	width: 100%;
	z-index: 1;
}

.site-main .sidebar-inner {
	margin: 0 auto;
}


/**
 * 4.0 Header
 * ----------------------------------------------------------------------------
 */


.site-title {
	font-size: 60px;
	font-weight: bold;
	line-height: 1;
	margin: 0;
	padding: 58px 0 10px;
}

.site-description {
	font: 300 italic 24px "Source Sans Pro", Helvetica, sans-serif;
	margin: 0;
}


/**
 * 4.2 Navigation
 * ----------------------------------------------------------------------------
 */

.main-navigation {
	clear: both;
	margin: 0 auto;
	min-height: 45px;
	position: relative;
}

ul.nav-menu,
div.nav-menu > ul {
	margin: 0;
}

.nav-menu li {
	display: inline-block;
	position: relative;
}

.nav-menu li a {
	color: #141412;
	display: block;
	font-size: 15px;
	line-height: 1;
	padding: 15px 20px;
	text-decoration: none;
}

.nav-menu li:hover > a,
.nav-menu li a:hover,
.nav-menu li:focus > a,
.nav-menu li a:focus {
	opacity:0.35;
	color: #757575;
}

.nav-menu .sub-menu li:hover > a,
.nav-menu .sub-menu li a:hover,
.nav-menu .sub-menu li:focus > a,
.nav-menu .sub-menu li a:focus {
	opacity:1;
	color: #757575;
}

.nav-menu .sub-menu,
.nav-menu .children {
	background-color: #220e10;
	border: 2px solid #f7f5e7;
	border-top: 0;
	padding: 0;
	position: absolute;
	left: -2px;
	overflow: hidden;
	clip: rect(1px, 1px, 1px, 1px);
}

.nav-menu .sub-menu ul,
.nav-menu .children ul {
	border-left: 0;
	left: 100%;
	top: 0;
}

ul.nav-menu ul a,
.nav-menu ul ul a {
	color: #fff;
	margin: 0;
}

ul.nav-menu li:hover > ul,
.nav-menu ul li:hover > ul,
ul.nav-menu .focus > ul,
.nav-menu .focus > ul {
	clip: inherit;
	overflow: inherit;
	height: inherit;
	width: inherit;
}

.nav-menu .current_page_item > a,
.nav-menu .current_page_ancestor > a,
.nav-menu .current-menu-item > a,
.nav-menu .current-menu-ancestor > a {
	color: #bc360a;
}

.menu-toggle {
	display: none;
}

/* Navbar */
.navbar {
	background-color: #f7f5e7;
	margin: 0 auto;
	width: 100%;
}



/**
 * 5.0 Content
 * ----------------------------------------------------------------------------
 */

.entry-header,
.entry-content,
.entry-summary,
.entry-meta {
	margin: 0 auto;
	width: 100%;
}




/**
 * 5.1 Entry Header
 * ----------------------------------------------------------------------------
 */

.sidebar .entry-header .entry-meta {
	padding: 0;
}




/**
 * 5.2 Entry Meta
 * ----------------------------------------------------------------------------
 */

.entry-meta {
	clear: both;
	font-size: 14px;
}

.entry-meta a {
	color: #bc360a;
}

.entry-meta a:hover {
	color: #bc360a;
}

.entry-meta > span {
	margin-right: 20px;
}

.entry-meta > span:last-child {
	margin-right: 0;
}

.featured-post:before {
	content: "\f308";
	margin-right: 2px;
}

.entry-meta .date a:before {
	content: "\f303";
}

.comments-link a:before {
	content: "\f300";
	margin-right: 2px;
	position: relative;
	top: -1px;
}

.entry-meta .author a:before {
	content: "\f304";
	position: relative;
	top: -1px;
}

.categories-links a:first-child:before {
	content: "\f301";
}

.tags-links a:first-child:before {
	content: "\f302";
	position: relative;
	top: -1px;
}

.edit-link a:before {
	content: "\f411";
	position: relative;
	top: -1px;
}

.single-author .entry-meta .author,
.sticky.format-standard .entry-meta .date,
.sticky.format-audio .entry-meta .date,
.sticky.format-chat .entry-meta .date,
.sticky.format-image .entry-meta .date,
.sticky.format-gallery .entry-meta .date {
	display: none;
}


/**
 * 5.3 Entry Content
 * ----------------------------------------------------------------------------
 */

.entry-content {
	-webkit-hyphens: auto;
	-moz-hyphens:    auto;
	-ms-hyphens:     auto;
	hyphens:         auto;
	word-wrap: break-word;
}


.entry-content blockquote {
	font-size: 24px;
}

.entry-content blockquote cite,
.entry-content blockquote small {
	font-size: 16px;
}

.entry-content img.alignleft,
.entry-content .wp-caption.alignleft {
	margin-left: -60px;
}

.entry-content img.alignright,
.entry-content .wp-caption.alignright {
	margin-right: -60px;
}

footer.entry-meta {
	margin-top: 24px;
}

.format-standard footer.entry-meta {
	margin-top: 0;
}

/* Page links */
.page-links {
	clear: both;
	font-size: 16px;
	font-style: italic;
	font-weight: normal;
	line-height: 2.2;
	margin: 20px 0;
	text-transform: uppercase;
}

.page-links a,
.page-links > span {
	background: #fff;
	border: 1px solid #fff;
	padding: 5px 10px;
	text-decoration: none;
}

.format-status .entry-content .page-links a,
.format-gallery .entry-content .page-links a,
.format-chat .entry-content .page-links a,
.format-quote .entry-content .page-links a,
.page-links a {
	background: #e63f2a;
	border: 1px solid #e63f2a;
	color: #fff;
}

.format-gallery .entry-content .page-links a:hover,
.format-audio .entry-content .page-links a:hover,
.format-status .entry-content .page-links a:hover,
.format-video .entry-content .page-links a:hover,
.format-chat .entry-content .page-links a:hover,
.format-quote .entry-content .page-links a:hover,
.page-links a:hover {
	background: #fff;
	color: #e63f2a;
}

.format-status .entry-content .page-links > span,
.format-quote .entry-content .page-links > span {
	background: none;
}

.page-links .page-links-title {
	background: transparent;
	border: none;
	margin-right: 20px;
	padding: 0;
}

/* Mediaelements */
.hentry .mejs-mediaelement,
.hentry .mejs-container .mejs-controls {
	background: #220e10;
}

.hentry .mejs-controls .mejs-time-rail .mejs-time-loaded,
.hentry .mejs-controls .mejs-horizontal-volume-slider .mejs-horizontal-volume-current {
	background: #fff;
}

.hentry .mejs-controls .mejs-time-rail .mejs-time-current {
	background: #ea9629;
}

.hentry .mejs-controls .mejs-time-rail .mejs-time-total,
.hentry .mejs-controls .mejs-horizontal-volume-slider .mejs-horizontal-volume-total {
	background: #595959;
}

.hentry .mejs-controls .mejs-time-rail span,
.hentry .mejs-controls .mejs-horizontal-volume-slider .mejs-horizontal-volume-total,
.hentry .mejs-controls .mejs-horizontal-volume-slider .mejs-horizontal-volume-current {
	border-radius: 0;
}


/**
 * 5.4 Galleries
 * ----------------------------------------------------------------------------
 */

.gallery {
	margin-bottom: 20px;
	margin-left: -4px;
}

.gallery-item {
	float: left;
	margin: 0 4px 4px 0;
	overflow: hidden;
	position: relative;
}

.gallery-columns-1.gallery-size-medium,
.gallery-columns-1.gallery-size-thumbnail,
.gallery-columns-2.gallery-size-thumbnail,
.gallery-columns-3.gallery-size-thumbnail {
	display: table;
	margin: 0 auto 20px;
}

.gallery-columns-1 .gallery-item,
.gallery-columns-2 .gallery-item,
.gallery-columns-3 .gallery-item {
	text-align: center;
}

.gallery-columns-4 .gallery-item {
	max-width: 23%;
	max-width: -webkit-calc(25% - 4px);
	max-width:         calc(25% - 4px);
}

.gallery-columns-5 .gallery-item {
	max-width: 19%;
	max-width: -webkit-calc(20% - 4px);
	max-width:         calc(20% - 4px);
}

.gallery-columns-6 .gallery-item {
	max-width: 15%;
	max-width: -webkit-calc(16.7% - 4px);
	max-width:         calc(16.7% - 4px);
}

.gallery-columns-7 .gallery-item {
	max-width: 13%;
	max-width: -webkit-calc(14.28% - 4px);
	max-width:         calc(14.28% - 4px);
}

.gallery-columns-8 .gallery-item {
	max-width: 11%;
	max-width: -webkit-calc(12.5% - 4px);
	max-width:         calc(12.5% - 4px);
}

.gallery-columns-9 .gallery-item {
	max-width: 9%;
	max-width: -webkit-calc(11.1% - 4px);
	max-width:         calc(11.1% - 4px);
}

.gallery-columns-1 .gallery-item:nth-of-type(1n),
.gallery-columns-2 .gallery-item:nth-of-type(2n),
.gallery-columns-3 .gallery-item:nth-of-type(3n),
.gallery-columns-4 .gallery-item:nth-of-type(4n),
.gallery-columns-5 .gallery-item:nth-of-type(5n),
.gallery-columns-6 .gallery-item:nth-of-type(6n),
.gallery-columns-7 .gallery-item:nth-of-type(7n),
.gallery-columns-8 .gallery-item:nth-of-type(8n),
.gallery-columns-9 .gallery-item:nth-of-type(9n) {
	margin-right: 0;
}

.gallery-columns-1.gallery-size-medium figure.gallery-item:nth-of-type(1n+1),
.gallery-columns-1.gallery-size-thumbnail figure.gallery-item:nth-of-type(1n+1),
.gallery-columns-2.gallery-size-thumbnail figure.gallery-item:nth-of-type(2n+1),
.gallery-columns-3.gallery-size-thumbnail figure.gallery-item:nth-of-type(3n+1) {
	clear: left;
}

.gallery-caption {
	background-color: rgba(0, 0, 0, 0.7);
	box-sizing: border-box;
	color: #fff;
	font-size: 14px;
	line-height: 1.3;
	margin: 0;
	max-height: 50%;
	opacity: 0;
	padding: 2px 8px;
	position: absolute;
	bottom: 0;
	left: 0;
	text-align: left;
	-webkit-transition: opacity 400ms ease;
	transition:         opacity 400ms ease;
	width: 100%;
}

.gallery-caption:before {
	box-shadow: 0 -10px 15px #000 inset;
	content: "";
	height: 100%;
	min-height: 49px;
	position: absolute;
	left: 0;
	top: 0;
	width: 100%;
}

.gallery-item:hover .gallery-caption {
	opacity: 1;
}

.gallery-columns-7 .gallery-caption,
.gallery-columns-8 .gallery-caption,
.gallery-columns-9 .gallery-caption {
	display: none;
}


/**
 * 5.5 Post Formats
 * ----------------------------------------------------------------------------
 */

/* Aside */
.format-aside {
	background-color: #f7f5e7;
}

.blog .format-aside:first-of-type,
.single .format-aside:first-of-type,
.format-aside + .format-aside,
.format-aside + .format-link,
.format-link + .format-aside {
	box-shadow: inset 0 2px 2px rgba(173, 165, 105, 0.2);
}

.format-aside .entry-meta {
	margin-top: 0;
}

.format-aside blockquote {
	font-size: 100%;
	font-weight: normal;
}

.format-aside cite {
	font-size: 100%;
	text-transform: none;
}

.format-aside cite:before {
	content: "\2014";
	margin-right: 5px;
}

/* Audio */
.format-audio {
	background-color: #db572f;
}

.format-audio .entry-title {
	font-size: 28px;
	font-weight: bold;
}

.format-audio .entry-content:before {
	content: "\f109";
	float: left;
	font-size: 64px;
	position: relative;
	top: 4px;
}

.format-audio .entry-content a,
.format-audio .entry-meta a,
.format-audio .entry-content a:hover,
.format-audio .entry-meta a:hover {
	color: #fbfaf3;
}

.format-audio .audio-content {
	background: url(images/dotted-line.png) repeat-y left top;
	background-size: 4px 4px;
	float: right;
	padding-left: 35px;
	width: 80%;
	width: -webkit-calc(100% - 85px);
	width:         calc(100% - 85px);
}

.format-audio .wp-audio-shortcode {
	height: 30px !important; /* Override mediaelement.js style */
	margin: 20px 0;
	max-width: 400px !important; /* Override mediaelement.js style */
}

.format-audio audio {
	max-width: 100% !important; /* Avoid player width overflow. */
}

/* Chat */
.format-chat {
	background-color: #eadaa6;
}

.format-chat .entry-title {
	font-size: 28px;
	font-weight: bold;
}

.format-chat .entry-meta a,
.format-chat .entry-content a {
	color: #722d19;
}

.format-chat .entry-meta .date a:before {
	content: "\f108";
	margin-right: 2px;
}

.format-chat .entry-meta .author {
	display: none;
}

.format-chat .chat {
	margin: 0;
}

.format-chat .chat .chat-timestamp {
	color: #722d19;
	float: right;
	font-size: 12px;
	font-weight: normal;
	margin: 5px 10px 0;
}

.format-chat .chat .fn {
	font-style: normal;
}

/* Gallery */
.format-gallery {
	background-color: #fbca3c;
}

.format-gallery .entry-header {
	margin-bottom: 15px;
}

.format-gallery .entry-title {
	font-size: 50px;
	font-weight: 400;
	margin: 0;
}

.format-gallery .entry-meta a,
.format-gallery .entry-content a {
	color: #722d19;
}

/* Image */
.format-image .entry-title {
	font-size: 28px;
	font-weight: bold;
}

.format-image .categories-links,
.format-image .tags-links {
	display: none;
}

/* Link */
.format-link {
	background-color: #f7f5e7;
}

.blog .format-link:first-of-type,
.single .format-link:first-of-type {
	box-shadow: inset 0 2px 2px rgba(173, 165, 105, 0.2);
}

.format-link .entry-header,
.format-link .entry-content p:last-child {
	margin-bottom: 0;
}

.format-link .entry-title {
	color: #ca3c08;
	display: inline;
	font: 300 italic 20px "Source Sans Pro", Helvetica, sans-serif;
	margin-right: 20px;
}

.format-link .entry-title a {
	color: #bc360a;
}

.format-link div.entry-meta {
	display: inline;
}

/* Quote */
.format-quote {
	background-color: #210d10;
}

.format-quote .entry-content,
.format-quote .entry-meta {
	color: #f7f5e7;
}

.format-quote .entry-content blockquote {
	font-size: 28px;
	margin: 0;
}

.format-quote .entry-content a,
.format-quote .entry-meta a,
.format-quote .linked {
	color: #e63f2a;
}

.format-quote .entry-content cite a {
	border-bottom: 1px dotted #fff;
	color: #fff;
}

.format-quote .entry-content cite a:hover {
	text-decoration: none;
}

.format-quote blockquote small,
.format-quote blockquote cite {
	display: block;
	font-size: 16px;
}

.format-quote blockquote {
	font-style: italic;
	font-weight: 300;
	padding-left: 75px;
	position: relative;
}

.format-quote blockquote:before {
	content: '\201C';
	font-size: 140px;
	font-weight: 400;
	line-height: .8;
	padding-right: 25px;
	position: absolute;
	left: -15px;
	top: -3px;
}

.format-quote .entry-meta .author {
	display: none;
}

/* Status */
.format-status {
	background-color: #722d19;
	padding: 0;
}

.format-status .entry-content,
.format-status .entry-meta {
	padding-left: 35px;
	position: relative;
}

.format-status .entry-content a {
	color: #eadaa6;
}

.format-status .entry-meta a {
	color: #f7f5e7;
}

.sidebar .format-status .entry-content,
.sidebar .format-status .entry-meta {
	padding-left: 95px;
}

.format-status .entry-content:before,
.format-status .entry-meta:before {
	background: url(images/dotted-line.png) repeat-y left bottom;
	background-size: 4px 4px;
	content: "";
	display: block;
	height: 100%;
	position: absolute;
	left: 10px;
	top: 0;
	width: 1px;
}

.sidebar .format-status .entry-content:before,
.sidebar .format-status .entry-meta:before {
	left: 70px;
}

.format-status .categories-links,
.format-status .tags-links {
	display: none;
}

/* Ensures the dots in the dot background are in lockstep. */
.format-status .entry-meta:before {
	background-position: left top;
}

.format-status .entry-content {
	color: #f7f5e7;
	font-size: 24px;
	font-style: italic;
	font-weight: 300;
	padding-bottom: 30px;
	padding-top: 40px;
	position: relative;
}

.format-status .entry-content p:first-child:before {
	background-color: rgba(0, 0, 0, 0.65);
	content: "";
	height: 3px;
	margin-top: 13px;
	position: absolute;
	left: 4px;
	width: 13px;
}

.sidebar .format-status .entry-content > p:first-child:before {
	left: 64px;
}

.format-status .entry-content p:last-child {
	margin-bottom: 0;
}

.format-status .entry-meta {
	margin-top: 0;
	padding-bottom: 40px;
}

.format-status .entry-meta .date a:before {
	content: "\f105";
}

/* Video */
.format-video {
	background-color: #db572f;
}

.format-video .entry-content a,
.format-video .entry-meta a,
.format-video .entry-content a:hover,
.format-video .entry-meta a:hover {
	color: #fbfaf3;
}

.format-video .entry-title {
	font-size: 50px;
	font-weight: 400;
}

.format-video .entry-meta {
	color: #220e10;
}


/**
 * 5.6 Attachments
 * ----------------------------------------------------------------------------
 */

.attachment .hentry {
	background-color: #e8e5ce;
	margin: 0;
	padding: 0;
}

.attachment .entry-header {
	margin-bottom: 0;
	padding: 30px 0;
}

.attachment .entry-title {
	display: inline-block;
	float: left;
	font: 300 italic 30px "Source Sans Pro", Helvetica, sans-serif;
	margin: 0;
}

.attachment .entry-title:before {
	content: "\f416";
	font-size: 32px;
	margin-right: 10px;
}

.attachment .entry-meta {
	clear: none;
	color: inherit;
	float: right;
	padding: 9px 0 0;
	text-align: right;
}

.hentry.attachment:not(.image-attachment) .entry-meta {
	max-width: 104px;
}

.attachment footer.entry-meta {
	display: none;
}

.attachment-meta:before {
	content: "\f307";
}

.full-size-link a:before {
	content: "\f402";
}

.full-size-link:before {
	content: none;
}

.attachment .entry-meta a,
.attachment .entry-meta .edit-link:before,
.attachment .full-size-link:before {
	color: #ca3c08;
}

.attachment .entry-content {
	background-color: #fff;
	max-width: 100%;
	padding: 40px 0;
}

.image-navigation {
	margin: 0 auto;
	position: relative;
}

.image-navigation a:hover {
	text-decoration: none;
}

.image-navigation .nav-previous,
.image-navigation .nav-next {
	position: absolute;
	top: 50px;
}

.image-navigation .nav-previous {
	left: 0;
}

.image-navigation .nav-next {
	right: 0;
}

.image-navigation .meta-nav {
	font-size: 32px;
	font-weight: 300;
	vertical-align: -4px;
}

.attachment .entry-attachment,
.attachment .type-attachment p {
	margin: 0 auto;
	text-align: center;
}

.attachment .entry-attachment .attachment {
	display: inline-block;
}

.attachment .entry-caption {
	text-align: left;
}

.attachment .entry-description {
	margin: 20px auto 0;
}

.attachment .entry-caption p:last-child,
.attachment .entry-description p:last-child {
	margin: 0;
}

.attachment .site-main .sidebar-container {
	display: none;
}

.attachment .entry-content .mejs-audio {
	max-width: 400px;
	margin: 0 auto;
}

.attachment .entry-content .wp-video {
	margin: 0 auto;
}

.attachment .entry-content .mejs-container {
	margin-bottom: 24px;
}

/**
 * 5.7 Post/Paging Navigation
 * ----------------------------------------------------------------------------
 */

.navigation .nav-previous {
	float: left;
}

.navigation .nav-next {
	float: right;
}

.navigation a {
	color: #bc360a;
}

.navigation a:hover {
	color: #ea9629;
	text-decoration: none;
}

.paging-navigation {
	background-color: #e8e5ce;
	padding: 40px 0;
}

.paging-navigation .nav-links {
	margin: 0 auto;
	width: 100%;
}

.sidebar .paging-navigation .nav-links {
	padding: 0 376px 0 60px;
}

.paging-navigation .nav-next {
	padding: 13px 0;
}

.paging-navigation a {
	font-size: 22px;
	font-style: italic;
	font-weight: 300;
}

.paging-navigation .meta-nav {
	background-color: #e63f2a;
	border-radius: 50%;
	color: #fff;
	display: inline-block;
	font-size: 26px;
	padding: 3px 0 8px;
	text-align: center;
	width: 50px;
}

.paging-navigation .nav-previous .meta-nav {
	margin-right: 10px;
	padding: 17px 0 23px;
	width: 80px;
}

.paging-navigation .nav-next .meta-nav {
	margin-left: 10px;
}

.paging-navigation a:hover .meta-nav {
	background-color: #ea9629;
	text-decoration: none;
}

.post-navigation {
	background-color: #fff;
	color: #ca3c08;
	font-size: 20px;
	font-style: italic;
	font-weight: 300;
	padding: 20px 0;
}

.post-navigation .nav-links {
	margin: 0 auto;
}

.sidebar .post-navigation .nav-links {
	padding: 0 376px 0 60px;
}

.post-navigation a[rel="next"] {
	float: right;
	text-align: right;
}


/**
 * 5.8 Author Bio
 * ----------------------------------------------------------------------------
 */

.author-info {
	margin: 0 auto;
	padding: 30px 0 10px;
	text-align: left; /* gallery & video post formats */
	width: 100%;
}

.author.sidebar .author-info {
	padding: 30px 376px 10px 60px;
}

.single .author-info {
	padding: 50px 0 0;
}

.author-avatar .avatar {
	float: left;
	margin: 0 30px 30px 0;
}

.single-format-status .author-description {
	color: #f7f5e7;
}

.author-description .author-title {
	clear: none;
	font: 300 italic 20px "Source Sans Pro", Helvetica, sans-serif;
	margin: 0 0 8px;
}

.author-link {
	color: #ca3c08;
	margin-left: 2px;
}

.author.archive .author-link {
	display: none;
}


/**
 * 5.9 Archives
 * ----------------------------------------------------------------------------
 */

.archive-header {
	background-color: #e8e5ce;
}

.archive-title,
.archive-meta {
	font: 300 italic 30px "Source Sans Pro", Helvetica, sans-serif;
	margin: 0 auto;
	padding: 30px 0;
	width: 100%;
}

.archive-meta {
	font-size: 16px;
	font-style: normal;
	font-weight: normal;
	margin-top: -15px;
	padding: 0 0 11px;
}

.sidebar .archive-meta {
	padding-right: 316px;
}


/**
 * 5.10 Search Results/No posts
 * ----------------------------------------------------------------------------
 */

.page-header {
	background-color: #e8e5ce;
}

.page-title {
	font: 300 italic 30px "Source Sans Pro", Helvetica, sans-serif;
	margin: 0 auto;
	padding: 30px 0;
	width: 100%;
}

.page-content {
	margin: 0 auto;
	padding: 40px 0;
	width: 100%;
}

.sidebar .page-content {
	margin: 0 auto;
	padding: 40px 376px 40px 60px;
}


/**
 * 5.11 404
 * ----------------------------------------------------------------------------
 */

.error404 .page-header {
	background-color: #fff;
}

.error404 .page-title {
	line-height: 0.6;
	margin: 0;
	padding: 300px;
	position: relative;
	text-align: center;
	width: auto;
}

.error404 .page-title:before {
	color: #e8e5ce;
	content: "\f423";
	font-size: 964px;
	line-height: 0.6;
	overflow: hidden;
	position: absolute;
	left: 7px;
	top: 28px;
}

.error404 .page-wrapper {
	background-color: #e8e5ce;
}

.error404 .page-header,
.error404 .page-content {
	margin: 0 auto;
	padding-bottom: 40px;
	width: 100%;
}


/**
 * 5.12 Comments
 * ----------------------------------------------------------------------------
 */

.comments-title,
.comment-list,
.comment-reply-title,
.must-log-in,
.comment-respond .comment-form,
.comment-respond iframe {
	display: block;
	margin-left: auto;
	margin-right: auto;
	width: 100%;
}

.sidebar .comments-title,
.sidebar .comment-list,
.sidebar .must-log-in,
.sidebar .comment-reply-title,
.sidebar .comment-navigation,
.sidebar .comment-respond .comment-form {
	padding-left: 60px;
	padding-right: 376px;
}

.comments-title {
	font: 300 italic 28px "Source Sans Pro", Helvetica, sans-serif;
}

.comment-list,
.comment-list .children {
	list-style-type: none;
	padding: 0;
}

.comment-list .children {
	margin-left: 20px;
}

.comment-list > li:after,
.comment-list .children > li:before {
	background: url(images/dotted-line.png) repeat left top;
	background-size: 4px 4px;
	content: "";
	display: block;
	height: 1px;
	width: 100%;
}

.comment-list > li:last-child:after {
	display: none;
}

.comment-body {
	padding: 24px 0;
	position: relative;
}

.comment-author {
	float: left;
}

.comment-author .avatar {
	display: block;
	margin-bottom: 10px;
}

.comment-author .fn {
	word-wrap: break-word;
}

.comment-author .fn,
.comment-author .url,
.comment-reply-link,
.comment-reply-login {
	color: #bc360a;
	font-size: 14px;
	font-style: normal;
	font-weight: normal;
}

.says {
	display: none;
}

.no-avatars .comment-author {
	margin: 0 0 5px;
	max-width: 100%;
	position: relative;
}

.no-avatars .comment-metadata,
.no-avatars .comment-content,
.no-avatars .comment-list .reply {
	width: 100%;
}

.bypostauthor > .comment-body .fn:before {
	content: "\f408";
	vertical-align: text-top;
}

.comment-list .edit-link {
	margin-left: 20px;
}

.comment-metadata,
.comment-awaiting-moderation,
.comment-content,
.comment-list .reply {
	float: right;
	width: 79%;
	width: -webkit-calc(100% - 124px);
	width:         calc(100% - 124px);
	word-wrap: break-word;
}

.comment-meta,
.comment-meta a {
	color: #a2a2a2;
	font-size: 13px;
}

.comment-meta a:hover {
	color: #ea9629;
}

.comment-metadata {
	margin-bottom: 20px;
}

.ping-meta {
	color: #a2a2a2;
	font-size: 13px;
	line-height: 2;
}

.comment-awaiting-moderation {
	color: #a2a2a2;
}

.comment-awaiting-moderation:before {
	content: "\f414";
	margin-right: 5px;
	position: relative;
	top: -2px;
}

.comment-reply-link:before,
.comment-reply-login:before {
	content: "\f412";
	margin-right: 3px;
}

/* Comment form */
.comment-respond {
	background-color: #f7f5e7;
	padding: 30px 0;
}

.comment .comment-respond {
	margin-bottom: 20px;
	padding: 20px;
}

.comment-reply-title {
	font: 300 italic 28px "Source Sans Pro", Helvetica, sans-serif;
}

.comment-reply-title small a {
	color: #131310;
	display: inline-block;
	float: right;
	height: 16px;
	overflow: hidden;
	width: 16px;
}

.comment-reply-title small a:hover {
	color: #ed331c;
	text-decoration: none;
}

.comment-reply-title small a:before {
	content: "\f406";
	vertical-align: top;
}

.sidebar .comment-list .comment-reply-title,
.sidebar .comment-list .comment-respond .comment-form {
	padding: 0;
}

.comment-form .comment-notes {
	margin-bottom: 15px;
}

.comment-form .comment-form-author,
.comment-form .comment-form-email,
.comment-form .comment-form-url {
	margin-bottom: 8px;
}

.comment-form [for="author"],
.comment-form [for="email"],
.comment-form [for="url"],
.comment-form [for="comment"] {
	float: left;
	padding: 5px 0;
	width: 120px;
}

.comment-form .required {
	color: #ed331c;
}

.comment-form input[type="text"],
.comment-form input[type="email"],
.comment-form input[type="url"] {
	width: 60%;
}

.comment-form textarea {
	width: 100%;
}

.form-allowed-tags,
.form-allowed-tags code {
	color: #686758;
	font-size: 12px;
}

.form-allowed-tags code {
	font-size: 10px;
	margin-left: 3px;
}

.comment-list .pingback,
.comment-list .trackback {
	padding-top: 24px;
}

.comment-navigation {
	font-size: 20px;
	font-style: italic;
	font-weight: 300;
	margin: 0 auto;
	padding: 20px 0 30px;
	width: 100%;
}

.no-comments {
	background-color: #f7f5e7;
	font-size: 20px;
	font-style: italic;
	font-weight: 300;
	margin: 0;
	padding: 40px 0;
	text-align: center;
}

.sidebar .no-comments {
	padding-left: 60px;
	padding-right: 376px;
}


/**
 * 5.13 Multisite
 * ----------------------------------------------------------------------------
 */

.site-main .mu_register {
	margin: 0 auto;
	width: 100%;
}

.mu_alert {
	margin-top: 25px;
}

.site-main .mu_register input[type="submit"],
.site-main .mu_register #blog_title,
.site-main .mu_register #user_email,
.site-main .mu_register #blogname,
.site-main .mu_register #user_name {
	font-size: inherit;
	width: 270px;
}

.site-main .mu_register input[type="submit"] {
	width: auto;
}


/**
 * 6.0 Sidebar
 * ----------------------------------------------------------------------------
 */

.site-main .widget-area {
	float: right;
	width: 300px;
}


/**
 * 6.1 Widgets
 * ----------------------------------------------------------------------------
 */

.widget {
	background-color: rgba(247, 245, 231, 0.7);
	font-size: 14px;
	-webkit-hyphens: auto;
	-moz-hyphens:    auto;
	-ms-hyphens:     auto;
	hyphens:         auto;
	margin: 0 0 24px;
	padding: 20px;
	word-wrap: break-word;
}

.widget .widget-title {
	font: 300 italic 20px "Source Sans Pro", Helvetica, sans-serif;
	margin: 0 0 10px;
}

.widget ul,
.widget ol {
	list-style-type: none;
	margin: 0;
	padding: 0;
}

.widget li {
	padding: 5px 0;
}

.widget .children li:last-child {
	padding-bottom: 0;
}

.widget li > ul,
.widget li > ol {
	margin-left: 20px;
}

.widget a {
	color: #bc360a;
}

.widget a:hover {
	color: #ea9629;
}

/* Search widget */
.search-form .search-submit {
	display: none;
}

/* RSS Widget */
.widget_rss .rss-date {
	display: block;
}

.widget_rss .rss-date,
.widget_rss li > cite {
	color: #a2a2a2;
}

/* Calendar Widget */
.widget_calendar table,
.widget_calendar td {
	border: 0;
	border-collapse: separate;
	border-spacing: 1px;
}

.widget_calendar caption {
	font-size: 14px;
	margin: 0;
}

.widget_calendar th,
.widget_calendar td {
	padding: 0;
	text-align: center;
}

.widget_calendar a {
	display: block;
}

.widget_calendar a:hover {
	background-color: rgba(0, 0, 0, 0.15);
}

.widget_calendar tbody td {
	background-color: rgba(255, 255, 255, 0.5);
}

.site-footer .widget_calendar tbody td {
	background-color: rgba(255, 255, 255, 0.05);
}

.widget_calendar tbody .pad, .site-footer .widget_calendar tbody .pad {
	background-color: transparent;
}


/**
 * 7.0 Footer
 * ----------------------------------------------------------------------------
 */

.site-footer {
	background-color: #e8e5ce;
	color: #686758;
	font-size: 14px;
	text-align: center;
}

.site-footer .widget-area,
.sidebar .site-footer {
	text-align: left;
}

.site-footer a {
	color: #686758;
}

.site-footer .sidebar-container {
	background-color: #220e10;
	padding: 20px 0;
}

.site-footer .widget-area {
	margin: 0 auto;
	width: 100%;
}

.sidebar .site-footer .widget-area {
	position: relative;
	left: -158px;
}

.site-footer .widget {
	background: transparent;
	color: #fff;
	float: left;
	margin-right: 20px;
	width: 245px;
}

.sidebar .site-footer .widget {
	width: 228px;
}

.sidebar .site-footer .widget:nth-of-type(4),
.sidebar .site-footer .widget:nth-of-type(3) {
	margin-right: 0;
}

.site-footer .widget a {
	color: #e6402a;
}

.site-footer .widget-title,
.site-footer .widget-title a,
.site-footer .wp-caption-text {
	color: #fff;
}

.site-info {
	margin: 0 auto;
	padding: 30px 0;
	width: 100%;
}

#wpstats {
	display: block;
	margin: -10px auto 0;
}


/**
 * 8.0 Media Queries
 * ----------------------------------------------------------------------------
 */

/* Does the same thing as <meta name="viewport" content="width=device-width">,
 * but in the future W3C standard way. -ms- prefix is required for IE10+ to
 * render responsive styling in Windows 8 "snapped" views; IE10+ does not honor
 * the meta tag. See http://core.trac.wordpress.org/ticket/25888.
 */
@-ms-viewport {
	width: device-width;
}
@viewport {
	width: device-width;
}

@media (max-width: 1599px) {
	.site {
		border: 0;
	}
}

@media (max-width: 1069px) {
	.sidebar img.alignleft,
	.sidebar .wp-caption.alignleft {
		margin-left: 0;
	}

	.sidebar img.alignright,
	.sidebar .wp-caption.alignright {
		margin-right: 0;
	}

	.error404 .page-header {
		margin-left: auto;
		width: 100%;
	}

	.archive-header,
	.search .page-header,
	.archive .page-header,
	.blog .page-header,
	.error404 .page-content,
	.search .page-content,
	.archive .page-content,
	.attachment .entry-header,
	.attachment .entry-content,
	.post-navigation .nav-links,
	.sidebar .site-info,
	.site-footer .widget-area {
		padding-left: 20px;
		padding-right: 20px;
	}

	.error404 .page-title {
		font-size: 24px;
		padding: 180px;
	}

	.error404 .page-title:before {
		font-size: 554px;
	}


	.image-navigation .nav-previous,
	.image-navigation .nav-next {
		position: static;
	}

	.site-main .widget-area {
		margin-right: 60px;
	}
}

@media (max-width: 999px) {
	.sidebar .entry-header,
	.sidebar .entry-content,
	.sidebar .entry-summary,
	.sidebar .entry-meta,
	.sidebar .comment-list,
	.sidebar .comment-reply-title,
	.sidebar .comment-navigation,
	.sidebar .comment-respond .comment-form,
	.sidebar .featured-gallery,
	.sidebar .post-navigation .nav-links,
	.author.sidebar .author-info {
		padding-left: 0;
		padding-right: 0;
	}

	.sidebar .archive-meta,
	.attachment .entry-header,
	.search.sidebar .page-content,
	.blog.sidebar .page-content,
	.sidebar .site-info,
	.sidebar .comments-title,
	.sidebar .no-comments {
		padding-left: 0;
		padding-right: 0;
	}

	.attachment .entry-meta {
		float: left;
		text-align: left;
		width: 100%;
	}

	.attachment .entry-content {
		max-width: 100%;
		padding: 40px 0;
	}

	.format-status .entry-content {
		padding-top: 40px;
	}

	.format-status .entry-meta {
		padding-bottom: 40px;
	}

	.sidebar .format-status .entry-content,
	.sidebar .format-status .entry-meta {
		padding-left: 35px;
	}

	.sidebar .format-status .entry-content:before,
	.sidebar .format-status .entry-meta:before {
		left: 10px;
	}

	.sidebar .format-status .entry-content p:first-child:before {
		left: 4px;
	}

	.sidebar .paging-navigation .nav-links {
		padding: 0 60px;
	}

	.site-main .sidebar-container {
		height: auto;
		margin: 0 auto;
		position: relative;
		top: 20px;
	}

	.site-main .widget-area {
		float: none;
		margin: 0;
		width: 100%;
	}

	.sidebar .site-footer .widget-area {
		max-width: 100%;
		left: 0;
	}
}

/* Collapse oversized image and pulled images after iPad breakpoint. */
@media (max-width: 767px) {
	.entry-content img.alignleft,
	.entry-content .wp-caption.alignleft {
		margin-left: 0;
	}

	.entry-content img.alignright,
	.entry-content .wp-caption.alignright {
		margin-right: 0;
	}

	.attachment .image-navigation,
	.attachment .entry-attachment .attachment {
		padding: 0;
		width: 100%;
	}

	.gallery-caption {
		display: none;
	}
}

@media (max-width: 643px) {
	.site-title {
		font-size: 30px;
	}

	#content .entry-header,
	#content .entry-content,
	#content .entry-summary,
	#content footer.entry-meta,
	#content .featured-gallery,
	.search.sidebar .page-content,
	.blog.sidebar .page-content,
	.sidebar .post-navigation .nav-links,
	.paging-navigation .nav-links,
	#content .author-info,
	.comments-area .comments-title,
	.comments-area .comment-list,
	.comments-area .comment-navigation,
	.comment-respond,
	.sidebar .site-info,
	.sidebar .paging-navigation .nav-links {
		padding-left: 20px;
		padding-right: 20px;
	}

	#content .format-status .entry-content,
	#content .format-status .entry-met {
		padding-left: 35px;
	}

	/* Small menu */
	.menu-toggle {
		cursor: pointer;
		display: inline-block;
		font: bold 16px/1.3 "Source Sans Pro", Helvetica, sans-serif;
		margin: 0;
		padding: 12px 0 12px 20px;
	}

	.menu-toggle:after {
		content: "\f502";
		font-size: 12px;
		padding-left: 8px;
		vertical-align: -4px;
	}

	.toggled-on .menu-toggle:after {
		content: "\f500";
		vertical-align: 2px;
	}

	.toggled-on .nav-menu,
	.toggled-on .nav-menu > ul {
		display: block;
		margin-left: 0;
		padding: 0;
		width: 100%;
	}

	.toggled-on li,
	.toggled-on .children {
		display: block;
	}

	.toggled-on .nav-menu li > ul {
		background-color: transparent;
		display: block;
		float: none;
		margin-left: 20px;
		position: relative;
		left: auto;
		top: auto;
	}

	.toggled-on .nav-menu li > ul a {
		color: #141412;
		width: auto;
	}

	.toggled-on .nav-menu li:hover > a,
	.toggled-on .nav-menu .children a {
		background-color: transparent;
		color: #141412;
	}

	.toggled-on .nav-menu li a:hover,
	.toggled-on .nav-menu ul a:hover {
		background-color: #db572f;
		color: #fff;
	}

	ul.nav-menu,
	div.nav-menu > ul {
		display: none;
	}

	#content .featured-gallery {
		padding-left: 24px;
	}

	.gallery-columns-1 .gallery-item {
		margin-right: 0;
		width: 100%;
	}

	.entry-title,
	.format-chat .entry-title,
	.format-image .entry-title,
	.format-gallery .entry-title,
	.format-video .entry-title {
		font-size: 22px;
		font-weight: bold;
	}

	.format-quote blockquote,
	.format-status .entry-content {
		font-size: 18px;
	}

	.format-quote blockquote small,
	.format-quote blockquote cite {
		font-size: 13px;
	}

	.error404 .page-title {
		padding: 40px 0 0;
	}

	.error404 .page-title:before {
		content: normal;
	}

	.comment-author {
		margin-right: 30px;
	}

	.comment-author .avatar {
		height: auto;
		max-width: 100%;
	}

	.comment-metadata,
	.comment-content,
	.comment-list .reply {
		width: 70%;
		width: -webkit-calc(100% - 104px);
		width:         calc(100% - 104px);
	}

	.comment-form input[type="text"],
	.comment-form input[type="email"],
	.comment-form input[type="url"] {
		width: -webkit-calc(100% - 120px);
		width:         calc(100% - 120px);
	}

	.comment-form textarea {
		height: 80px; /* Smaller field for mobile. */
	}

	/* Audio */
	.format-audio .entry-content:before {
		display: none;
	}

	.format-audio .audio-content {
		background-image: none;
		float: none;
		padding-left: 0;
		width: auto;
	}
}

/* Mobile devices */
@media (max-width: 359px) {
	.gallery {
		margin-left: 0;
	}

	.gallery .gallery-item,
	.gallery-columns-2.gallery-size-thumbnail .gallery-item {
		max-width: none;
		width: 49%;
		width: -webkit-calc(50% - 4px);
		width:         calc(50% - 4px);
	}

	.gallery-columns-1.gallery-size-medium,
	.gallery-columns-1.gallery-size-thumbnail,
	.gallery-columns-2.gallery-size-thumbnail,
	.gallery-columns-3.gallery-size-thumbnail {
		display: block;
	}

	.gallery-columns-1 .gallery-item,
	.gallery-columns-1.gallery-size-medium .gallery-item,
	.gallery-columns-1.gallery-size-thumbnail .gallery-item {
		text-align: center;
		width: 98%;
		width: -webkit-calc(100% - 4px);
		width:         calc(100% - 4px);
	}

	.gallery-columns-3 .gallery-item:nth-of-type(3n),
	.gallery-columns-5 .gallery-item:nth-of-type(5n),
	.gallery-columns-7 .gallery-item:nth-of-type(7n),
	.gallery-columns-9 .gallery-item:nth-of-type(9n) {
		margin-right: 4px;
	}

	.gallery br {
		display: none;
	}

	.gallery .gallery-item:nth-of-type(even) {
		margin-right: 0;
	}

	/* Comments */
	.comment-author {
		margin: 0 0 5px;
		max-width: 100%;
	}

	.comment-author .avatar {
		display: inline;
		margin: 0 5px 0 0;
		max-width: 20px;
	}

	.comment-metadata,
	.comment-content,
	.comment-list .reply {
		width: 100%;
	}
}


/**
 * 9.0 Print
 * ----------------------------------------------------------------------------
 */

/* Retina-specific styles. */
@media print,
	(-o-min-device-pixel-ratio: 5/4),
	(-webkit-min-device-pixel-ratio: 1.25),
	(min-resolution: 120dpi) {


	.format-audio .audio-content,
	.format-status .entry-content:before,
	.format-status .entry-meta:before,
	.comment-list > li:after,
	.comment-list .children > li:before {
		background-image: url(images/dotted-line-2x.png);
	}
}

@media print {
	body {
		background: none !important;
		color: #000;
		font-size: 10pt;
	}

	footer a[rel="bookmark"]:link:after,
	footer a[rel="bookmark"]:visited:after {
		content: " [" attr(href) "] "; /* Show URLs */
	}

	.site {
		max-width: 98%;
	}

	.site-title {
		color: #000;
		font-size: 21pt;
	}

	.site-description {
		font-size: 10pt;
	}

	.author-avatar,
	.site-footer,
	.comment-respond,
	.comments-area .comment-edit-link,
	.comments-area .reply,
	.comments-link,
	.entry-meta .edit-link,
	.page-links,
	.site-content nav,
	.widget-area,
	.main-navigation,
	.navbar,
	.more-link {
		display: none;
	}

	.entry-header,
	.entry-content,
	.entry-summary,
	.entry-meta {
		margin: 0;
		width: 100%;
	}

	.page-title,
	.entry-title {
		font-size: 21pt;
	}

	.entry-meta,
	.entry-meta a {
		color: #444;
		font-size: 10pt;
	}

	.entry-content img.alignleft,
	.entry-content .wp-caption.alignleft {
		margin-left: 0;
	}

	.entry-content img.alignright,
	.entry-content .wp-caption.alignright {
		margin-right: 0;
	}

	.format-image .entry-content .size-full {
		margin: 0;
	}

	/* Remove colors from post formats */
	.hentry {
		background-color: #fff;
	}

	/* Comments */
	.comments-area > li.comment {
		background: none;
		position: relative;
		width: auto;
	}

	.comment-metadata {
		float: none;
	}

	.comment-author .fn,
	.comment-reply-link,
	.comment-reply-login {
		color: #333;
	}
}
