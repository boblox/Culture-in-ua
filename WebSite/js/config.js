/*
	TXT 2.0 by HTML5 UP
	html5up.net | @n33co
	Free for personal and commercial use under the CCA 3.0 license (html5up.net/license)
*/

window._skel_config = {
    preset: 'standard',
    prefix: '/css/style',
    resetCSS: true
};

window._skel_panels_config = {
    preset: 'standard'
};

jQuery(function () {
    jQuery('#nav > ul').dropotron({
        offsetY: -6,
        offsetX: -1,
        mode: 'fade',
        noOpenerFade: true,
        alignment: 'left',
        detach: false
    });
});

/*Google analytics*/
//(function (i, s, o, g, r, a, m) {
//    i['GoogleAnalyticsObject'] = r; i[r] = i[r] || function () {
//        (i[r].q = i[r].q || []).push(arguments);
//    }, i[r].l = 1 * new Date(); a = s.createElement(o),
//    m = s.getElementsByTagName(o)[0]; a.async = 1; a.src = g;
//    m.parentNode.insertBefore(a, m);
//})(window, document, 'script', '//www.google-analytics.com/analytics.js', 'ga');

//ga('create', 'UA-54105375-1', 'auto');
//ga('send', 'pageview');
/*End of Google analytics*/