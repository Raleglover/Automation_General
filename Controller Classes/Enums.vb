Public Enum ePropultionType
    UNKNOW = 0
    HYDRAULIC = 1                                               'Hydros
    TRACTION = 2                                                'AC Tractions
End Enum
Public Enum eTractionMachineType
    UNKNOW = 0
    GEARED = 1                                                  'has mechnical gearbox
    GEARLESS = 2                                                'PM (Permanent Magnet) no gear box
End Enum
Public Enum eHydraulicValueType
    UNKNOW = 0
    FOUR_VALUE = 1                                              'typical 4 valve setup
    VARIABLE_VALUE = 2                                          'Buchter Value system
End Enum
Public Enum eHallDoorType
    UNKNOW = 0
    COUPLED = 1                                                   'car door opens hall door
    MANUAL = 2                                                  'hall door (lift or slide)
    SWING = 3                                                   'hall door (pull or push)
End Enum
Public Enum eCarDoorType
    UNKNOW = 0
    AUTOMATIC = 1                                               'automatic door operator 
    MANUAL_GATE = 2                                             'manual gate (slide)
End Enum
Public Enum eOpeningType
    NONE = 0                                                    'no opening at landing
    FRONT = 1                                                   'front opening
    REAR = 2                                                    'rear opening
    SIDE = 4                                                    'side opening (we have never had a 3rd door yet)
End Enum