﻿$(function () {

    /* initialize the external events
     -----------------------------------------------------------------*/
    function ini_events(ele) {
        ele.each(function () {
            // create an Event Object (https://fullcalendar.io/docs/event-object)
            // it doesn't need to have a start or end
            var eventObject = {
                title: $.trim($(this).text()) // use the element's text as the event title
            }

            // store the Event Object in the DOM element so we can get to it later
            $(this).data('eventObject', eventObject)

            // make the event draggable using jQuery UI
            $(this).draggable({
                zIndex: 1070,
                revert: true, // will cause the event to go back to its
                revertDuration: 0  //  original position after the drag
            })

        })
    }

    ini_events($('#external-events div.external-event'))

    /* initialize the calendar
     -----------------------------------------------------------------*/
    //Date for the calendar events (dummy data)
    var date = new Date()
    var d = date.getDate(),
        m = date.getMonth(),
        y = date.getFullYear()

    var Calendar = FullCalendar.Calendar;
    var Draggable = FullCalendar.Draggable;

    var containerEl = document.getElementById('external-events');
    var calendarEl = document.getElementById('calendar');

    // initialize the external events
    // -----------------------------------------------------------------

    new Draggable(containerEl, {
        itemSelector: '.external-event',
        eventData: function (eventEl) {
            return {
                title: eventEl.innerText,
                description: eventEl.attributes["data-value-description"].value,
                requestid: eventEl.attributes["data-value-ID"].value,
                backgroundColor: window.getComputedStyle(eventEl, null).getPropertyValue('background-color'),
                borderColor: window.getComputedStyle(eventEl, null).getPropertyValue('background-color'),
                textColor: window.getComputedStyle(eventEl, null).getPropertyValue('color'),
            };
        }
    });
    var calendar = new Calendar(calendarEl, {
        headerToolbar: {
            left: 'prev,next today',
            center: 'title',
            right: 'timeGridWeek,timeGridDay,list'
        },
        initialView: 'timeGridWeek',
        themeSystem: 'bootstrap',
        //Random default events
        events: 'Calender/GetEvents',
        editable: true,
        droppable: true, // this allows things to be dropped onto the calendar !!!
        eventClick: function (sender) {
            currentEvent = sender;

            if ($(this).data("qtip")) $(this).qtip("hide");

            // add data to input
           
            $('#ID').val(sender.event.extendedProps.requestid);
            $('#event-title').html(sender.event.title);
            $('#Description').val(sender.event.extendedProps.description);
            $('#StartText').val(sender.event.start);
            $('#Start').val(sender.event.start);
            $('#EndText').val(sender.event.end);
            $('#End').val(sender.event.end);

            // show model
            $('#eventModal').modal('show');

        },
        drop: function (info) {
            // remove the element from the "Draggable Events" list
            info.draggedEl.parentNode.removeChild(info.draggedEl);
        },
        eventChange: function (sender) {
            currentEvent = sender;

            if ($(this).data("qtip")) $(this).qtip("hide");

            // add data to input
            //$('#ID').val(sender.event.id);
            $('#ID').val(sender.event.extendedProps.requestid);
            $('#event-title').html(sender.event.title);
            $('#Description').val(sender.event.extendedProps.description);
            $('#StartText').val(sender.event.start);
            $('#Start').val(sender.event.start);
            $('#EndText').val(sender.event.end);
            $('#End').val(sender.event.end);

            // show model
            $('#eventModal').modal('show');

        },
    });

    calendar.render();
    // $('#calendar').fullCalendar()

    /* ADDING EVENTS */
    var currColor = '#3c8dbc' //Red by default
    // Color chooser button
    $('#color-chooser > li > a').click(function (e) {
        e.preventDefault()
        // Save color
        currColor = $(this).css('color')
        // Add color effect to button
        $('#add-new-event').css({
            'background-color': currColor,
            'border-color': currColor
        })
    })

    $('#add-new-event').click(function (e) {
        e.preventDefault()
        // Get value and make sure it is not null
        var val = $('#new-event').val()
        if (val.length == 0) {
            return
        }

        // Create events
        var event = $('<div />')
        event.css({
            'background-color': currColor,
            'border-color': currColor,
            'color': '#fff'
        }).addClass('external-event')
        event.text(val)
        $('#external-events').prepend(event)

        // Add draggable funtionality
        ini_events(event)

        // Remove event from text input
        $('#new-event').val('')
    })
});
