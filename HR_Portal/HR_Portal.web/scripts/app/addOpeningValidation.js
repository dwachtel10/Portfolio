$(document)
    .ready(function() {
        $('#addOpeningForm')
            .validate({
                rules: {
                    JobTitle: {
                        required: true
                    },
                    JobLocation: {
                        required: true
                    },
                    JobDescription: {
                        required: true
                    },
                    JobPhone: {
                        required: true,
                        phoneUS: true
                    },
                    JobEmail: {
                        required: true,
                        email: true
                    }
                },
                messages: {
                    JobTitle: {
                        required: "Enter a job title."
                    },
                    JobLocation: {
                        required: "Enter a location."
                    },
                    JobDescription: {
                        required: "Enter a description."
                    },
                    JobPhone: {
                        required: "Enter a contact phone number.",
                        phoneUS: "Invalid format."
                    },
                    JobEmail: {
                        required: "Enter a contact email.",
                        email: "Invalid format."
                    }
                }
            });
    });