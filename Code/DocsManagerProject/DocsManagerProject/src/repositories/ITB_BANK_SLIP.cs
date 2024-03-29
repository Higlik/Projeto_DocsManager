﻿using DocsManagerProject.src.dto;
using DocsManagerProject.src.models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DocsManagerProject.src.repositories
{
    /// <Sumary>
    /// <para>Resume> Creating Interface for Bank Slip </para>
    /// <para>By: Higlik <para>
    /// <para>Version: 1.0</para>
    /// <para>Date:18/05/2022</para>
    /// </summary>
    public interface ITB_BANK_SLIP
    {
        Task NewBankSlip(NewBankSlipDTO newBankSlip);

        Task UpdateBankSlip(UpdateBankSlipDTO updateBankSlip);

        Task<List<TB_BANK_SLIP>> GetBankSlipBySearch(double value, string expirationDate, string cnpj);

        Task<TB_BANK_SLIP> GetBankSlipById(int idBankSlip);
    }
}
