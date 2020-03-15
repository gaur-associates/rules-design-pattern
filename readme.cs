var action = "withdraw";

var check = book switch
{
    { Attribute: { name: "English" } } => "found",
    _ => "Not found"

};
Console.WriteLine($"result - {check}");


            book.count = 0;

            var check = (book, action) switch
            {
                ({ Attribute: { name: "English" }, count: 0 }, "withdraw") => "All books are checked out",
                ({ Attribute: { name: "English" } }, "withdraw") => "found",
                _ => "Not found"

            };