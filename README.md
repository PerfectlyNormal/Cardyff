# Cardyff

Build JSON payload for [actionable message cards][actionmessages] easily
with IntelliSense or similar systems. Skip the tedious looking up of
documentation just to figure out how they spelled that field this time around.

## Dependencies

Uses [Json.NET][jsonnet] as the rest of the C# world does when JSON is involved.
Other than that, nothing.

## Why

* Because I hate referencing documentation continuously.
* Because I didn't look for any existing projects.
* Because it's not 1998, so string concatenation can die in a fire.
* Because I haven't found a decent templating library.
* Because creating dynamic objects and serializing fell down hard when a field
  wanted to include an `@`, which C# decided should be removed.
* Because.

## Examples

```c#
var card = new Cardyff.MessageCard
{
    Summary = "Someone set up us the bomb",
    Title = "All your base are belong to us",
    ThemeColor = "0078d7",
    Sections = new[]
    {
        new Section()
        {
            ActivityTitle = "",
            ActivitySubtitle = "CATS",
            ActivityImage = "https://upload.wikimedia.org/wikipedia/en/0/03/Aybabtu.png",
            Text = "All your base are belong to us",
            Facts = new[]
            {
                new Fact()
                {
                    Name = "Section:",
                    Value = "Introduction"
                },
                new Fact()
                {
                    Name = "Location:",
                    Value = "Zero Wing"
                }
            }
        }
    },
    Actions = new[]
    {
        new OpenUriAction()
        {
            Name = "View on Wikipedia",
            Type = "OpenUri",
            Targets = new[]
            {
                new OpenUriTarget()
                {
                    OS = "default",
                    Uri = "https://en.wikipedia.org/wiki/All_your_base_are_belong_to_us"
                }
            }
        }
    }
};

JsonConvert.SerializeObject(card);
```

## What's with the name?

**Card** **f**ormatter **f**unctionality.

Also, I'm funny.

## License

MIT. Always.

[actionmessages]: https://docs.microsoft.com/en-us/outlook/actionable-messages/
[jsonnet]: https://www.newtonsoft.com/json