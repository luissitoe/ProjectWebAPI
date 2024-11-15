﻿namespace ProjectWebAPI.Models
{
    public class Cliente
    {
        public Guid Id { get; set; }

        public required string Nome { get; set; }    
        public required string Apelido { get; set; } 
        public required string Telefone { get; set; }   
        public string? Email { get; set; }  
    }
}
