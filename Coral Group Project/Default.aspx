<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %> 

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"  >

       <main class="w-100">
        <section class=" mb-5 hero-section container-fluid" style="background-image: url('https://source.unsplash.com/1600x900/?nature,environment'); background-size: cover; background-position: center; height: 75vh; padding: 150px 0px; color: #fff; text-align: center;">
            <div>
                <h1 class="display-4 fw-bold mb-4">Carbon Footprint Tracker Application</h1>
                <p class="lead mb-4">Embrace a sustainable future with our user-friendly and efficient tool.</p>
                <a href="/DataEntry" class="btn btn-primary btn-lg">Get Started</a>
            </div>
        </section>

        <section class="my-5 py-5">
            <div class="container-fluid">
                <div class="row align-items-center m-5">
                    <div class="col-md-4 col-sm-4" style="margin: 3% 2%; border:thin;">
                        <img src="https://source.unsplash.com/800x600/?forest,trees" alt="Nature Image" class="rounded mb-4" style="max-width: 95%; max-height: auto;  border-radius: 8px; ">
                    </div>

                    <div class="col-md-6" style="margin: 3% 2%;">
                        <h2 class="fw-bold mb-4">Monitor and Manage Your Carbon Footprint</h2>
                        <p>With a sleek interface and intuitive features, users can easily input and track their daily activities, energy consumption, and transportation choices to quantify their environmental impact.</p>
                    </div>
                </div>
            </div>
        </section>

        <section class="bg-light py-5 w-100">
            <div class="container-fluid"  style="margin: auto; display:flex; justify-content:space-around;">
                <div class="row align-items-center text-center">
                    <div class="col-md-3 col-sm-3 mb-3" style="margin: 3%;">
                        <div class="card h-100 shadow">
                            <img src="https://source.unsplash.com/600x400/?solar-panels,renewable-energy" alt="Renewable Energy" class="card-img-top" style="margin: 2%; max-width: 185px; border-radius: 8px;">
                            <div class="card-body">
                                <h4 class="card-title">Renewable Energy</h4>
                                <p class="card-text">Discover eco-friendly energy solutions and reduce your carbon footprint.</p>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-3 mb-3" style="margin: 3%;">
                        <div class="card h-100 shadow">
                            <img src="https://source.unsplash.com/600x400/?electric-vehicles,transportation" alt="Electric Vehicles" class="card-img-top" style="margin: 2%; max-width: 185px; border-radius: 8px;">
                            <div class="card-body">
                                <h4 class="card-title">Green Transportation</h4>
                                <p class="card-text">Explore sustainable transportation options and reduce your carbon emissions.</p>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-3 mb-3" style="margin: 3%;">
                        <div class="card h-100 shadow">
                            <img src="https://source.unsplash.com/600x400/?recycling,eco-friendly" alt="Eco-Friendly" class="card-img-top" style="margin: 2%; max-width: 185px; border-radius: 8px;">
                            <div class="card-body">
                                <h4 class="card-title">Eco-Friendly Living</h4>
                                <p class="card-text">Adopt a sustainable lifestyle and be part of the solution.</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    </main>

</asp:Content>
