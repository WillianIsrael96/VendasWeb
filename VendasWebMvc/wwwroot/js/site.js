$(function () {
    $('[data-js-effect="fade-in"]').hide().fadeIn(600);

    var $backToTop = $('<button type="button" class="back-to-top" aria-label="Voltar ao topo">Topo</button>');
    $('body').append($backToTop);

    $(window).on('scroll', function () {
        $backToTop.toggleClass('is-visible', $(this).scrollTop() > 220);
    });

    $backToTop.on('click', function () {
        $('html, body').animate({ scrollTop: 0 }, 450);
    });

    var $contactForm = $('#contactForm');
    var $message = $('#contactMessage');
    var $counter = $('#messageCounter');

    function updateCounter() {
        $counter.text($message.val().length);
    }

    if ($message.length && $counter.length) {
        $message.on('input', updateCounter);
        updateCounter();
    }

    $contactForm.on('submit', function (event) {
        event.preventDefault();

        var form = this;
        var isValid = form.checkValidity();

        $(form).addClass('was-validated');
        $('#contactSuccess').toggleClass('d-none', !isValid);

        if (isValid) {
            form.reset();
            $(form).removeClass('was-validated');
            updateCounter();
        }
    });
});
