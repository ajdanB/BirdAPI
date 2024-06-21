﻿using BirdAPI.ApiService.Database;
using BirdAPI.ApiService.Database.Models;
using MediatR;

namespace BirdAPI.ApiService.Commands;

public class AddUserCommand : IRequest<Guid>
{
    public String Name { get; set; }

    public class CreateUserHandler(ApplicationGraphContext context) : IRequestHandler<AddUserCommand, Guid>
    {
        public async Task<Guid> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User
            {
                Id = Guid.NewGuid(),
                Name = request.Name
            };

            context.Users.Add(user);
            await context.SaveChangesAsync();

            Console.WriteLine($"User {user.Id} with Name {user.Name} created");

            return user.Id;
        }
    }
}