namespace TastyEatsBD.Core.Enums;

/// <summary>
/// Represents various statuses of a payment transaction.
/// </summary>
public enum PaymentStatus
{
    /// <summary>
    /// Payment has been initiated but is not yet processed.
    /// </summary>
    Pending,

    /// <summary>
    /// Payment is successfully completed.
    /// </summary>
    Completed,

    /// <summary>
    /// Payment failed during processing due to an error or rejection.
    /// </summary>
    Failed,

    /// <summary>
    /// Payment was canceled by the user or system.
    /// </summary>
    Canceled,

    /// <summary>
    /// Payment was successfully refunded.
    /// </summary>
    Refunded,

    /// <summary>
    /// The payment is under review or awaiting further action.
    /// </summary>
    UnderReview
}
