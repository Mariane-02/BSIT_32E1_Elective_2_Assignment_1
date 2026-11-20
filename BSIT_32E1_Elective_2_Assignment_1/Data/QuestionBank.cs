using BSIT_32E1_Elective_2_Assignment_1.Models;

namespace BSIT_32E1_Elective_2_Assignment_1.Data;

public static class QuestionBank
{
    public static List<Question> All => new()
    {
        new Question {
            Number = 1,
            Text = "What is the fundamental difference between Server-Side Rendering (SSR/MVC) and a Decoupled Web API architecture?",
            Options = {
                "SSR returns JSON payloads, whereas a Web API compiles .cshtml Razor views on the server.",
                "SSR compiles HTML views on the server and sends fully rendered markup to the browser, whereas a Web API acts as a stateless data provider returning raw JSON.",
                "SSR only works with mobile applications, whereas Web APIs are restricted to desktop web browsers.",
                "SSR requires client-side routing in React, whereas Web APIs manage HTML layouts directly on the server." },
            CorrectIndex = 1,
            Explanation = "MVC renders finished HTML on the server. A Web API only supplies data (usually JSON) and leaves presentation to any client."
        },
        new Question {
            Number = 2,
            Text = "Why do Web API controllers in ASP.NET Core inherit from ControllerBase instead of Controller?",
            Options = {
                "ControllerBase supports Razor View rendering using View() and ViewData.",
                "ControllerBase provides essential HTTP handling and routing without carrying unnecessary HTML view rendering overhead.",
                "Controller is obsolete in .NET 8 and cannot handle HTTP POST requests.",
                "ControllerBase automatically creates SQLite database files on application startup." },
            CorrectIndex = 1,
            Explanation = "Controller adds view support (View(), ViewData) on top of ControllerBase. APIs don't need it."
        },
        new Question {
            Number = 3,
            Text = "Which framework attribute automatically triggers an HTTP 400 Bad Request response when incoming request payloads fail structural model validation?",
            Options = { "[Route]", "[HttpGet]", "[ApiController]", "[FromQuery]" },
            CorrectIndex = 2,
            Explanation = "[ApiController] enables automatic model-state validation and returns 400 with problem details, plus binding-source inference."
        },
        new Question {
            Number = 4,
            Text = "Which HTTP status code should an API return after successfully creating a new resource via a POST request, along with a Location header pointing to the new URI?",
            Options = { "200 OK", "201 Created", "204 No Content", "404 Not Found" },
            CorrectIndex = 1,
            Explanation = "201 Created signals a new resource; CreatedAtAction() sets the Location header."
        },
        new Question {
            Number = 5,
            Text = "When a DELETE request successfully removes a resource from the server and returns no content in the response body, which HTTP status code is standard?",
            Options = { "200 OK", "201 Created", "204 No Content", "400 Bad Request" },
            CorrectIndex = 2,
            Explanation = "204 No Content means success with an empty body, returned via NoContent()."
        },
        new Question {
            Number = 6,
            Text = "Which of the following endpoint URIs follows RESTful resource-oriented naming best practices?",
            Options = {
                "GET /api/getAllCourses",
                "GET /api/courses",
                "POST /api/createNewCourseRecord",
                "POST /api/deleteCourseById?id=5" },
            CorrectIndex = 1,
            Explanation = "REST URIs name resources with plural nouns; the HTTP verb expresses the action."
        },
        new Question {
            Number = 7,
            Text = "What is the primary function of the [Route(\"api/[controller]\")] attribute in ASP.NET Core?",
            Options = {
                "It connects the controller directly to an Entity Framework database context.",
                "It maps incoming URI request paths to the controller class using the class name token.",
                "It encrypts all incoming JSON payloads.",
                "It enables Cross-Origin Resource Sharing (CORS) for external React apps." },
            CorrectIndex = 1,
            Explanation = "[controller] is replaced by the class name minus \"Controller\", so CoursesController is served at /api/courses."
        },
        new Question {
            Number = 8,
            Text = "Which HTTP verb is safe and idempotent, intended exclusively for retrieving resource data without altering server state?",
            Options = { "POST", "PUT", "GET", "DELETE" },
            CorrectIndex = 2,
            Explanation = "GET only reads data. Repeated calls have no side effects."
        }
    };
}
