() => {
    alert('document ready');
};


var Layout = (() => {
    e = () => {
        $(".sidenav-toggler").addClass("active"),
            $(".sidenav-toggler").data("action", "sidenav-unpin"),
            $("body").removeClass("g-sidenav-hidden").addClass("g-sidenav-show g-sidenav-pinned"),
            $("body").append('<div class="backdrop d-xl-none" data-action="sidenav-unpin" data-target=' + $("#sidenav-main").data("target") + " />"),
            Cookies.set("sidenav-state", "pinned");
    }
    a = () => {
        $(".sidenav-toggler").removeClass("active"),
            $(".sidenav-toggler").data("action", "sidenav-pin"),
            $("body").removeClass("g-sidenav-pinned").addClass("g-sidenav-hidden"),
            $("body").find(".backdrop").remove(),
            Cookies.set("sidenav-state", "unpinned");
    }
    isPinned = () => Cookies.get("sidenav-state") ? Cookies.get("sidenav-state") : "pinned";
    var t = Cookies.get("sidenav-state") ? Cookies.get("sidenav-state") : "pinned";
    $(window).width() > 1200 &&
        ("pinned" == t && e(),
            "unpinned" == Cookies.get("sidenav-state") && a(),
            $(window).resize(function () {
                $("body").hasClass("g-sidenav-show") && !$("body").hasClass("g-sidenav-pinned") && $("body").removeClass("g-sidenav-show").addClass("g-sidenav-hidden");
            })),
        $(window).width() < 1200 &&
        ($("body").removeClass("g-sidenav-hide").addClass("g-sidenav-hidden"),
            $("body").removeClass("g-sidenav-show"),
            $(window).resize(function () {
                $("body").hasClass("g-sidenav-show") && !$("body").hasClass("g-sidenav-pinned") && $("body").removeClass("g-sidenav-show").addClass("g-sidenav-hidden");
            })),
        $("body").on("click", "[data-action]", function (t) {
            t.preventDefault();
            var n = $(this),
                i = n.data("action");
            n.data("target");
            switch (i) {
                case "sidenav-pin":
                    e();
                    break;
                case "sidenav-unpin":
                    a();
                    break;
                case "search-show":
                    n.data("target"),
                        $("body").removeClass("g-navbar-search-show").addClass("g-navbar-search-showing"),
                        setTimeout(function () {
                            $("body").removeClass("g-navbar-search-showing").addClass("g-navbar-search-show");
                        }, 150),
                        setTimeout(function () {
                            $("body").addClass("g-navbar-search-shown");
                        }, 300);
                    break;
                case "search-close":
                    n.data("target"),
                        $("body").removeClass("g-navbar-search-shown"),
                        setTimeout(function () {
                            $("body").removeClass("g-navbar-search-show").addClass("g-navbar-search-hiding");
                        }, 150),
                        setTimeout(function () {
                            $("body").removeClass("g-navbar-search-hiding").addClass("g-navbar-search-hidden");
                        }, 300),
                        setTimeout(function () {
                            $("body").removeClass("g-navbar-search-hidden");
                        }, 500);
            }
        }),
        $(".sidenav").on("mouseenter", () => {
            $("body").hasClass("g-sidenav-pinned") || $("body").removeClass("g-sidenav-hide").removeClass("g-sidenav-hidden").addClass("g-sidenav-show");
        }),
        $(".sidenav").on("mouseleave", () => {
            $("body").hasClass("g-sidenav-pinned") ||
                ($("body").removeClass("g-sidenav-show").addClass("g-sidenav-hide"),
                    setTimeout(function () {
                        $("body").removeClass("g-sidenav-hide").addClass("g-sidenav-hidden");
                    }, 300));
        }),
        $(window).on("load resize", () => {
            $("body").height() < 800 && ($("body").css("min-height", "100vh"), $("#footer-main").addClass("footer-auto-bottom"));
        })
})(),
Navbar = (function () {
    var e = $(".navbar-nav, .navbar-nav .nav"),
        a = $(".navbar .collapse"),
        t = $(".navbar .dropdown");
    a.on({
        "show.bs.collapse": function () {
            var t;
            (t = $(this)).closest(e).find(a).not(t).collapse("hide");
        },
    }),
        t.on({
            "hide.bs.dropdown": function () {
                var e, a;
                (e = $(this)),
                    (a = e.find(".dropdown-menu")).addClass("close"),
                    setTimeout(function () {
                        a.removeClass("close");
                    }, 200);
            },
        });
})(),
NavbarCollapse = (function () {
    $(".navbar-nav");
    var e = $(".navbar .navbar-custom-collapse");
    e.length &&
        (e.on({
            "hide.bs.collapse": function () {
                e.addClass("collapsing-out");
            },
        }),
            e.on({
                "hidden.bs.collapse": function () {
                    e.removeClass("collapsing-out");
                },
            }));
})();