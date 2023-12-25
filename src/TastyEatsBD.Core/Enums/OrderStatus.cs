namespace TastyEatsBD.Core.Enums;

/// <summary>
/// Represents the various stages of an order's lifecycle.
/// </summary>
public enum OrderStatus
{
    /// <summary>
    /// Order has been placed by the customer and is awaiting rider assignment.
    /// </summary>
    Placed,

    /// <summary>
    /// A rider has been assigned to the order.
    /// </summary>
    RiderAssigned,

    /// <summary>
    /// Order has been sent to the restaurant and is awaiting preparation.
    /// </summary>
    SentToRestaurant,

    /// <summary>
    /// Restaurant is currently preparing the order.
    /// </summary>
    Preparing,

    /// <summary>
    /// Order preparation is complete and ready for pickup by the rider.
    /// </summary>
    ReadyForPickup,

    /// <summary>
    /// Rider has picked up the order and is en route to the delivery location.
    /// </summary>
    OutForDelivery,

    /// <summary>
    /// Rider has arrived at the delivery location.
    /// </summary>
    Arrived,

    /// <summary>
    /// Order has been delivered to the customer successfully.
    /// </summary>
    Delivered,

    /// <summary>
    /// Order was canceled before completion.
    /// </summary>
    Canceled
}
