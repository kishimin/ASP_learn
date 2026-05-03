using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using api.Interfaces;
using api.Data;
using api.Models;

namespace api.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly ApplicationDBContext _context;

        public CommentRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<List<Comment>> GetAllAsync()
        {
            return await _context.Comments.ToListAsync();
        }

        public async Task<Comment?> GetByIdAsync(int id)
        {
            return await _context.Comments.FindAsync(id);
        }

        // public async Task<Comment> CreateAsync(Comment commentModel)
        // {
        //     await _context.Comments.AddAsync(commentModel);
        //     await _context.SaveChangesAsync();
        //     return commentModel;
        // }

        // public async Task<Comment?> UpdateAsync(int id, UpdateCommentRequestDto commentDto)
        // {
        //     var existingComment = await _context.Comments.FirstOrDefaultAsync(x => x.Id == id);

        //     if (existingComment == null)
        //     {
        //         return null;
        //     }

        //     existingComment.Symbol = commentDto.Symbol;
        //     existingComment.CompanyName = commentDto.CompanyName;
        //     existingComment.Purchase = commentDto.Purchase;
        //     existingComment.LastDiv = commentDto.LastDiv;
        //     existingComment.Industry = commentDto.Industry;
        //     existingComment.MarketCap = commentDto.MarketCap;

        //     await _context.SaveChangesAsync();

        //     return existingComment;
        // }

        // public async Task<Comment?> DeleteAsync(int id)
        // {
        //     var commentModel = await _context.Comments.FirstOrDefaultAsync(x => x.Id == id);

        //     if (commentModel == null)
        //     {
        //         return null;
        //     }

        //     _context.Comments.Remove(commentModel);
        //     await _context.SaveChangesAsync();

        //     return commentModel;
        // }
    }
}