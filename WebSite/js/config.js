jQuery(function () {
    skel.init({
        preset: 'standard',
        prefix: '/css/style',
        reset: 'full',
        grid: { gutters: '2.5em' },
        breakpoints: {
            desktop: { range: "1201-", containers: 1200 },
            '1000px': { range: "481-1200", containers: '90%' },
            mobile: { range: "-480", containers: "fluid", lockViewport: true, grid: { collapse: true } }
        },
        plugins: {
            layers: {
                config: {
                    baseZIndex: 1000,
                    transform: false
                },
                titleBar: {
                    breakpoints: ['mobile'],
                    position: 'top-left',
                    width: '100%',
                    height: 44,
                    html: '<div class="toggle" data-action="toggleLayer" data-args="navPanel">&equiv;</div>'
                },
                navPanel: {
                    breakpoints: ['mobile'],
                    position: 'top-left',
                    width: 300,
                    height: '100%',
                    orientation: 'vertical',
                    side: 'left',
                    hidden: true,
                    animation: 'pushX',
                    clickToHide: true,
                    html: '<div data-args="nav" data-action="navList"></div>'
                }
            }
        }
    });

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
(function (i, s, o, g, r, a, m) {
    i['GoogleAnalyticsObject'] = r; i[r] = i[r] || function () {
        (i[r].q = i[r].q || []).push(arguments);
    }, i[r].l = 1 * new Date(); a = s.createElement(o),
    m = s.getElementsByTagName(o)[0]; a.async = 1; a.src = g;
    m.parentNode.insertBefore(a, m);
})(window, document, 'script', '//www.google-analytics.com/analytics.js', 'ga');

ga('create', 'UA-54105375-1', 'auto');
ga('send', 'pageview');
/*End of Google analytics*/