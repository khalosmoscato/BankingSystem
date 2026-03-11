using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystem
{
    // changed from `class` to `record` to make this data immutable
    public record BankTransaction(
        int TransactionId,
        string Type,
        decimal Amount,
        DateTime Timestamp,
        string Category
        );
}
