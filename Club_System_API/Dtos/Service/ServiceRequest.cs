﻿namespace Club_System_API.Dtos.Service
{
    public record ServiceRequest (

         string Name,
         decimal Price,
        string Description,
        IFormFile? Image

        );
}
