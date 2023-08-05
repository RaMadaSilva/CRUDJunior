﻿using CRUDJunior.Context;
using CRUDJunior.Models;
using CRUDJunior.UniteOfWork.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace CRUDJunior.UniteOfWork.Repositories
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        private readonly CrudeContext _context;

        public AlunoRepositorio(CrudeContext context)
        {
            _context = context;
        }

        public void DeleteAluno(int id)
        {
            var aluno = GetById(id); 
            _context.Remove(aluno);
        }

        public IEnumerable<Aluno> GetAll()
        {
            return _context.Alunos.AsNoTracking().ToList();
        }

        public Aluno GetById(int id)
        {
           return (Aluno)_context.Alunos.Where(x=>x.Id==id);
        }

        public void SaveAluno(Aluno aluno)
        {
            _context.Add(aluno); 
        }

        public void UpdateAluno(int id)
        {
            var aluno = GetById(id);
            _context.Entry(aluno).State = EntityState.Modified;
        }
    }
}
