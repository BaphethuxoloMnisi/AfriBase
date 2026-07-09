# Afribase Artifacts Auction

Afribase Artifacts Auction is a full-stack web application built with **ASP.NET Core MVC** that provides an online marketplace for buying, selling, and bidding on authentic African artifacts. The platform promotes African cultural heritage by allowing collectors, artisans, and enthusiasts to participate in secure online auctions through a modern, responsive web interface.

## Features

- User registration and authentication
- Secure login and account management
- Browse and search artifact listings
- Create, edit, and manage artifact auctions
- Place bids on active auctions
- View auction details and bidding history
- User dashboard for managing listings and bids
- Responsive design for desktop and mobile devices
- Role-based access (Administrator and User)

## Technologies Used

### Backend
- ASP.NET Core MVC
- C#
- Entity Framework Core
- ASP.NET Core Identity

### Frontend
- HTML5
- CSS3
- Bootstrap
- JavaScript

### Database
- SQL Server

### Development Tools
- Visual Studio 2022
- SQL Server Management Studio (SSMS)

## Project Structure

```
Afribase-Artifacts-Auction/
│
├── Controllers/
├── Models/
├── Views/
├── Data/
├── Services/
├── wwwroot/
│   ├── css/
│   ├── js/
│   └── images/
├── appsettings.json
├── Program.cs
└── README.md
```

## Installation

1. Clone the repository.

```bash
git clone https://github.com/yourusername/Afribase-Artifacts-Auction.git
```

2. Open the solution in **Visual Studio 2022**.

3. Update the SQL Server connection string in `appsettings.json`.

4. Apply the Entity Framework Core migrations.

```powershell
Update-Database
```

5. Run the application.

6. Open your browser and navigate to:

```
https://localhost:5001
```

## Usage

- Register a new account or log in.
- Browse available African artifacts.
- Create artifact listings and auction them.
- Place bids on active auctions.
- Manage your listings and bidding activity through your dashboard.

## Future Improvements

- Online payment integration
- Real-time bidding using SignalR
- Email notifications
- Wishlist functionality
- Ratings and reviews
- AI-powered artifact recommendations
- Multi-language support
- Image optimization and cloud storage

## Learning Outcomes

This project demonstrates proficiency in:

- ASP.NET Core MVC
- C#
- Entity Framework Core
- ASP.NET Core Identity
- SQL Server database management
- MVC architecture
- CRUD operations
- Authentication and authorization
- Responsive web development

## Screenshots

Add screenshots of the application here.

## Author

**Baphethuxolo Asiziphanga Mnisi**

GitHub: https://github.com/BaphethuxoloMnisi

LinkedIn: https://linkedin.com/in/baphethuxolo-mnisi

---

Afribase Artifacts Auction was developed as an academic project to demonstrate modern web application development using ASP.NET Core MVC while showcasing African cultural heritage through a secure online auction platform.
