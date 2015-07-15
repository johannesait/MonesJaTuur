# CoffeeScript

$(document).ready ->
    # DOM element with id = "content" will be replaced after data load.
    window.wiselinks = new Wiselinks($('#content'))

    $(document).off('page:always').on(
            'page:always'
            (event, xhr, settings) ->
                console.log("Wiselinks page loading completed")
                # code to stop loading animation
                $("a").attr("data-push", true)
        )