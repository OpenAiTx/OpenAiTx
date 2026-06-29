[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![CI - Build and Test](https://github.com/Tillman32/CleanArchitecture/actions/workflows/ci.yml/badge.svg)](https://github.com/Tillman32/CleanArchitecture/actions/workflows/ci.yml)
[![Deploy to GitHub Pages](https://github.com/Tillman32/CleanArchitecture/actions/workflows/pages.yml/badge.svg)](https://github.com/Tillman32/CleanArchitecture/actions/workflows/pages.yml)

![](https://raw.githubusercontent.com/Tillman32/CleanArchitecture/master/./src/CleanArchitecture.WASM/Preview.png)

[LIVE DEMO - WASM on GitHub Pages](https://tillman32.github.io/CleanArchitecture/)

# The motivation behind it all

What is the point of all this? Well, besides showcasing Bob Ross... I thought it would be clever to have a "real world" application to reference when talking architecture. I want something to set a standard, something to clone, something to utilize in all my next .Net Core projects. Like all software (and wine), this will improve with time. 

I also found it fitting, that "Uncle Bob" (Robert C. Martin) shares a similar name, and this project makes an attempt to align with his architecture [outlined here on his website.](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html)

I also wrote a blog post to pair with it here: [https://www.brandontillman.com/blog/clean-architecture-dotnet](https://www.brandontillman.com/blog/clean-architecture-dotnet)

# Key Points:

### :trident: N-Tier Architecture

A 3 layered approach, to set us up for multiple UI's that use the same core business functionality/back-end. 

### :open_file_folder: Separation of Concerns

Closely related to the ["Single Responsibility"](http://deviq.com/single-responsibility-principle/) principle, Separation of Concerns (SoC) makes your code more maintainable, by not co-locating ideas. When things change, SoC will help ensure your changes are limited to your feature set, and not spread throughout your application.

### :droplet: No Leaky Abstractions

By using interfaces, we can avoid leaky abstractions, and have better control of how our code is used. On the contrary, consumers of our code don't have to know the implementation details, they can simply use your interfaces/classes.

### :microscope: Testable

Testing code that is tightly coupled is nearly impossible. By following the SOC principal, and using interfaces our code will be easier to rest in result.

### :electric_plug: Modular

The code will be easier to modify in the future, because of a few reasons. Separation of concerns allows for fewer changes/testing throughout the application. You can build on specific feature sets, without modifying the rest of the code.

### :wrench: Maintainable

The code will inherently be more maintainable by following Clean Architecture patterns. Other developers will see the benefit of the clean separation, and follow suit.

# Primary Technologies Used

- [.Net](https://dotnet.microsoft.com/)
- [Blazor WASM](https://www.learnblazor.com/)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
- [AutoMapper](https://automapper.org/)
- [NLog](https://nlog-project.org/)

### :star2: Give it a Star! 
If you like or are using this project to learn or start your solution, please consider giving it a star. Thank you!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-29

---