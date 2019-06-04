using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace OCPI.DTO.v2_1_1.Shared
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ImageCategory
    {
        CHARGER, // Photo of the physical device that contains one or more EVSEs.
        ENTRANCE, // Location entrance photo. Should show the car entrance to the location from street side.
        LOCATION, // Location overview photo.
        NETWORK, // logo of an associated roaming network to be displayed with the EVSE for example in lists, maps and detailed information view
        OPERATOR, // logo of the charge points operator, for example a municipality, to be displayed with the
        EVSEs, // detailed information view or in lists and maps, if no networkLogo is present
        OTHER, // Other
        OWNER, // logo of the charge points owner, for example a local store, to be displayed with the EVSEs detailed information view
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum LocationType
    {
        ON_STREET, // Parking in public space.
        PARKING_GARAGE, // Multistorey car park.
        UNDERGROUND_GARAGE, // Multistorey car park, mainly underground.
        PARKING_LOT, // A cleared area that is intended for parking vehicles, i.e.at super markets, bars, etc.
        OTHER, // None of the given possibilities.
        UNKNOWN// Parking location type is not known by the operator (default).
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ParkingRestriction
    {
        EV_ONLY, // Reserved parking spot for electric vehicles.
        PLUGGED, // Parking is only allowed while plugged in (charging).
        DISABLED, // Reserved parking spot for disabled people with valid ID.
        CUSTOMERS, // Parking spot for customers/guests only, for example in case of a hotel or shop.
        MOTORCYCLES // Parking spot only suitable for (electric) motorcycles or scooters.
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PowerType
    {
        AC_1_PHASE, // AC mono phase.
        AC_3_PHASE, // AC 3 phase.
        DC, // Direct Current.
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Status
    {
        AVAILABLE, // The EVSE/Connector is able to start a new charging session.
        BLOCKED, // The EVSE/Connector is not accessible because of a physical barrier, i.e.a car.
        CHARGING, // The EVSE/Connector is in use.
        INOPERATIVE, // The EVSE/Connector is not yet active or it is no longer available (deleted).
        OUTOFORDER, // The EVSE/Connector is currently out of order.
        PLANNED, // The EVSE/Connector is planned, will be operating soon
        REMOVED, // The EVSE/Connector/charge point is discontinued/removed.
        RESERVED, // The EVSE/Connector is reserved for a particular EV driver and is unavailable for other drivers.
        UNKNOWN// No status information available. (Also used when offline)
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Facility
    {
        HOTEL, // A hotel.
        RESTAURANT, // A restaurant.
        CAFE, // A cafe.
        MALL, // A mall or shopping center.
        SUPERMARKET, // A supermarket.
        SPORT, // Sport facilities: gym, field etc.
        RECREATION_AREA, // A Recreation area.
        NATURE, // Located in, or close to, a park, nature reserve/park etc.
        MUSEUM, // A museum.
        BUS_STOP, // A bus stop.
        TAXI_STAND, // A taxi stand.
        TRAIN_STATION, // A train station.
        AIRPORT, // An airport.
        CARPOOL_PARKING, // A carpool parking.
        FUEL_STATION, // A Fuel station.
        WIFI // Wifi or other type of internet available.
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum EnvironmentalImpactCategory
    {
        NUCLEAR_WASTE, // Produced nuclear waste in gramms per kilowatthour.
        CARBON_DIOXIDE // Exhausted carbon dioxide in gramms per kilowarrhour.
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum EnergySourceCategory
    {
        NUCLEAR, // Nuclear power sources.
        GENERAL_FOSSIL, // All kinds of fossil power sources.
        COAL, // Fossil power from coal.
        GAS, // Fossil power from gas.
        GENERAL_GREEN, // All kinds of regenerative power sources.
        SOLAR, // Regenerative power from PV.
        WIND, // Regenerative power from wind turbines.
        WATER // Regenerative power from water turbines
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ConnectorType
    {
        CHADEMO, // The connector type is CHAdeMO, DC
        DOMESTIC_A, // Standard/Domestic household, type “A”, NEMA 1-15, 2 pins
        DOMESTIC_B, // Standard/Domestic household, type “B”, NEMA 5-15, 3 pins
        DOMESTIC_C, // Standard/Domestic household, type “C”, CEE 7/17, 2 pins
        DOMESTIC_D, // Standard/Domestic household, type “D”, 3 pin
        DOMESTIC_E, // Standard/Domestic household, type “E”, CEE 7/5 3 pins
        DOMESTIC_F, // Standard/Domestic household, type “F”, CEE 7/4, Schuko, 3 pins
        DOMESTIC_G, // Standard/Domestic household, type “G”, BS 1363, Commonwealth, 3 pins
        DOMESTIC_H, // Standard/Domestic household, type “H”, SI-32, 3 pins
        DOMESTIC_I, // Standard/Domestic household, type “I”, AS 3112, 3 pins
        DOMESTIC_J, // Standard/Domestic household, type “J”, SEV 1011, 3 pins
        DOMESTIC_K, // Standard/Domestic household, type “K”, DS 60884-2-D1, 3 pins
        DOMESTIC_L, // Standard/Domestic household, type “L”, CEI 23-16-VII, 3 pins
        IEC_60309_2_single_16, // IEC 60309-2 Industrial Connector single phase 16 Amperes (usually blue)
        IEC_60309_2_three_16, // IEC 60309-2 Industrial Connector three phase 16 Amperes (usually red)
        IEC_60309_2_three_32, // IEC 60309-2 Industrial Connector three phase 32 Amperes (usually red)
        IEC_60309_2_three_64, // IEC 60309-2 Industrial Connector three phase 64 Amperes (usually red)
        IEC_62196_T1, // IEC 62196 Type 1 “SAE J1772”
        IEC_62196_T1_COMBO, // Combo Type 1 based, DC
        IEC_62196_T2, // IEC 62196 Type 2 “Mennekes”
        IEC_62196_T2_COMBO, // Combo Type 2 based, DC
        IEC_62196_T3A, // IEC 62196 Type 3A
        IEC_62196_T3C, // IEC 62196 Type 3C “Scame”
        TESLA_R, // Tesla Connector “Roadster”-type (round, 4 pin)
        TESLA_S // Tesla Connector “Model-S”-type (oval, 5 pin)
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ConnectorFormat
    {
        SOCKET, // The connector is a socket; the EV user needs to bring a fitting plug.
        CABLE // The connector is an attached cable; the EV users car needs to have a fitting inlet.
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Capability
    {
        CHARGING_PROFILE_CAPABLE, // The EVSE supports charging profiles. Sending Charging Profiles is not yet supported by OCPI.
        CREDIT_CARD_PAYABLE, // Charging at this EVSE can be payed with credit card.
        REMOTE_START_STOP_CAPABLE, // The EVSE can remotely be started/stopped.
        RESERVABLE, // The EVSE can be reserved.
        RFID_READER, // Charging at this EVSE can be authorized with a RFID token
        UNLOCK_CAPABLE, // Connectors have mechanical lock that can be requested by the eMSP to be unlocked.
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum AuthMethod
    {
        AUTH_REQUEST, // Authentication request from the eMSP
        WHITELIST, // Whitelist used to authenticate, no request done to the eMSP
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CdrDimensionType
    {
        ENERGY, // defined in kWh, default step_size is 1 Wh
        FLAT, // flat fee, no unit
        MAX_CURRENT, // defined in A (Ampere), Maximum current reached during charging session.
        MIN_CURRENT, // defined in A (Ampere), Minimum current used during charging session.
        PARKING_TIME, // time not charging: defined in hours, default step_size is 1 second.
        TIME // time charging: defined in hours, default step_size is 1 second.
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SessionStatus
    {
        ACTIVE, // The session is accepted and active.
        COMPLETED, // The session is finished successfully.
        INVALID, // The session is declared invalid and will not be billed.
        PENDING // The session is pending and has not yet started. This is the initial state.
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TariffDimensionType
    {
        ENERGY, // defined in kWh, step_size multiplier: 1 Wh
        FLAT, // flat fee, no unit
        PARKING_TIME, // time not charging: defined in hours, step_size multiplier: 1 second
        TIME // time charging: defined in hours, step_size multiplier: 1 second
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DayOfWeek
    {
        MONDAY, // Monday
        TUESDAY, // Tuesday
        WEDNESDAY, // Wednesday
        THURSDAY, // Thursday
        FRIDAY, // Friday
        SATURDAY, // Saturday
        SUNDAY, // Sunday
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TokenType
    {
        OTHER,
        RFID
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum WhitelistType
    {
        ALWAYS, // Token always has to be whitelisted, realtime authorization is not possible/allowed.
        ALLOWED, // It is allowed to whitelist the token, realtime authorization is also allowed.
        ALLOWED_OFFLINE, // Whitelisting is only allowed when CPO cannot reach the eMSP (communication between CPO and eMSP is offline)
        NEVER, // Whitelisting is forbidden, only realtime authorization is allowed. Token should always be authorized by the eMSP.
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Allowed
    {
        ALLOWED, // This Token is allowed to charge at this location.
        BLOCKED, // This Token is blocked.
        EXPIRED, // This Token has expired.
        NO_CREDIT, // This Token belongs to an account that has not enough credits to charge at the given location.
        NOT_ALLOWED, // Token is valid, but is not allowed to charge at the given location.
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CommandResponseType
    {
        NOT_SUPPORTED, // The requested command is not supported by this CPO, Charge Point, EVSE etc.
        REJECTED, // Command request rejected by the CPO or Charge Point.
        ACCEPTED, // Command request accepted by the CPO or Charge Point.
        TIMEOUT, // Command request timeout, no response received from the Charge Point in an reasonable time.
        UNKNOWN_SESSION, // The Session in the requested command is not known by this CPO.
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CommandType
    {
        RESERVE_NOW, // Request the Charge Point to reserve a (specific) EVSE for a Token for a certain time, starting now.
        START_SESSION, // Request the Charge Point to start a transaction on the given EVSE/Connector.
        STOP_SESSION, // Request the Charge Point to stop an ongoing session.
        UNLOCK_CONNECTOR, // Request the Charge Point to unlock the connector (if applicable). This functionality is for help desk operators only!
    }
}
