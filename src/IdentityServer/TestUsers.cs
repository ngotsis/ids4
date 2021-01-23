// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityModel;
using IdentityServer4.Test;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text.Json;
using IdentityServer4;

namespace IdentityServer
{
    public class TestUsers
    {
        public static List<TestUser> Users
        {
            get
            {
                var address = new
                {
                    street_address = "Address1",
                    locality = "London",
                    postal_code = "NW1",
                    country = "United Kingdom"
                };
                
                return new List<TestUser>
                {
                    new TestUser
                    {
                        SubjectId = "nicksubject",
                        Username = "nick",
                        Password = "test123",
                        Claims =
                        {
                            new Claim(JwtClaimTypes.Name, "Nick G"),
                            new Claim(JwtClaimTypes.GivenName, "Nick"),
                            new Claim(JwtClaimTypes.FamilyName, "G"),
                            new Claim(JwtClaimTypes.Email, "email@hotmail.com"),
                            new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                            new Claim(JwtClaimTypes.WebSite, "http://website.com"),
                            new Claim(JwtClaimTypes.Address, JsonSerializer.Serialize(address), IdentityServerConstants.ClaimValueTypes.Json)
                        }
                    }
                };
            }
        }
    }
}