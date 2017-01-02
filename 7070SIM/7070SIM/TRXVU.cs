using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/// <summary>
/// ---------------------------------------------------------------------------------------------
/// this class refers to the ISIS TRXVU ICD
/// ---------------------------------------------------------------------------------------------
/// </summary>


namespace _7070SIM
{
    class TRXVU
    {

        private int watchdog;

        private byte[] beacon;

        public int Watchdog
        {
            get { return watchdog; }
            set { watchdog = value; }
        }

        public TRXVU()
        {

        }

        /// <summary>
        /// Performs a reset of the internal watchdog.
        /// </summary>
        public void watchdogReset()
        {

        }

        /// <summary>
        /// Performs a software reset of the transmitter processor.
        /// </summary>
        public void softwareTxReset()
        {

        }

        /// <summary>
        /// Performs a software reset of the receiver processor.
        /// </summary>
        public void softwareRxReset()
        {

        }

        /// <summary>
        /// Power cycles the full board (transmitter and receiver will be both reset). 
        /// </summary>
        public void hardwareReset()
        {

        }

        /// <summary>
        /// Retrieves the number of frames that are currently stored in the receiver buffer.
        /// </summary>
        /// <returns>
        /// [000 - 001] xxxxxxxx xxxxxxxx
        ///Number of frames in receive buffer.This number has a minimum value of 0 and a maximum
        ///value of the maximum number of frames that can be in the buffer. The latter is specified in the
        ///device configuration (see[AD01] for further details).
        /// </returns>
        public byte[] getNumberOfFramesInRxBuffer()
        {
            return null;
        }

        /// <summary>
        /// Retrieves the contents of the oldest frame in the receive buffer. The contents of the frame are
        ///preceded by two bytes that indicate the frame size in number of bytes.This size can be used
        ///by the OBC to terminate the transmission after all the relevant bytes have been received(when
        ///the actual size is less than the maximum size). It can also be used for easier processing of the
        ///frame contents by the OBC's command processor. If there are 0 frames in the receive buffer
        ///the response is undefined.
        /// </summary>
        /// <returns>
        /// [000 - 001] xxxxxxxx xxxxxxxx
        ///Frame contents size.This size has a minimum value of 1 and the maximum can be as specified
        ///in the device configuration(see[AD01] for further details.). The least significant byte is
        ///transmitted first(little endian).
        ///[002 - 003]
        ///xxxxxxxx 0000xxxx
        ///Doppler frequency.This field contains the measured Doppler shift on the packet at the
        ///reception time.The least significant byte is transmitted first (little endian).
        ///[004 - 005]
        ///xxxxxxxx 0000xxxx
        ///RSSI.This field contains the measured Received Signal Strength Indicator (RSSI) at the
        ///reception time.The least significant byte is transmitted first (little endian).
        ///[006 – 6 + N]
        ///n/a, binary
        ///Frame contents.The size of the data block depends on the received frame length and on the
        ///maximum frame size(see[AD01] for further details).
        /// </returns>
        public byte[] getFrameFromRxBuffer()
        {
            return null;
        }

        /// <summary>
        /// Removes the oldest frame from the receive buffer. This is the same frame that can be retrieved
        ///from the receiver buffer command.If there are 0 frames in the receive buffer this command
        ///has no effect.
        /// </summary>
        public void removeFrameFromBuffer()
        {

        }


        /// <summary>
        /// Measures all the available telemetry channels:
        ///      Transmitter supply current
        ///      Receiver supply current
        ///      Power amplifier temperature
        ///      Local oscillator temperature
        ///      Instantaneous received signal Doppler offset at the receiver port
        ///      Instantaneous received signal strength at the receiver port
        ///      Supply voltage
        /// </summary>
        /// <returns>
        /// [000 - 001] xxxxxxxx 0000xxxx
        ///Raw measurement value of the transmitter supply current.
        ///[002 - 003] xxxxxxxx 0000xxxx
        ///Raw measurement value of the instantaneous Doppler offset of the signal at the receiver port
        ///[004 - 005] xxxxxxxx 0000xxxx
        ///Raw measurement value of the receiver supply current.
        ///[006 - 007] xxxxxxxx 0000xxxx
        ///Raw measurement value of the power bus voltage.
        ///[008 - 009] xxxxxxxx 0000xxxx
        ///Raw measurement value of the local oscillator temperature.
        ///[010 - 011] xxxxxxxx 0000xxxx
        ///Raw measurement value of the power amplifier temperature.
        ///[012 - 013] xxxxxxxx 0000xxxx
        ///Raw measurement value of the instantaneous signal strength of the signal at the receiver.
        ///The least significant byte is transmitted first (little endian) for all the telemetry values.
        ///All the measurements have a minimum value of 0 and a maximum value of 4095. Please refer
        ///to Section 7.5 for the conversion formulas.
        /// </returns>
        public byte[] measureAllTLMChannels()
        {
            return null;
        }


        /// <summary>
        /// Reports the amount of time the receiver MCU has been active since the last reset, also known
        ///as up- time.The uptime is reported with a resolution of 1 second.The maximum supported
        ///uptime is 255 days, 23 hours, 59 minutes and 59 seconds, after which the uptime will overflow
        ///and the reported uptime will be 0 days, 0 hours, 0 minutes and 0 seconds.
        /// </summary>
        /// <returns>
        /// [000 - 000] 00xxxxxx
        ///Second part of the uptime value.This part has a minimum value of 0 and a maximum value of
        ///59.
        ///[001 - 001] 000xxxxx
        ///Minute part of the uptime value.This part has a minimum value of 0 and a maximum value of
        ///59.
        ///[002 - 002] 000xxxxx
        ///Hour part of the uptime value.This part has a minimum value of 0 and a maximum value of
        ///23.
        ///[003 - 003] xxxxxxxx
        ///Day part of the uptime value.This part has a minimum value of 0 and a maximum value of
        ///255.
        /// </returns>
        public byte[] reportRxUptime()
        {
            return null;
        }

        
        /// <summary>
        /// Adds a frame (AX.25 UI or HDLC frame, according to [AD01]) to the frame buffer of the
        ///transmitter. If the radio mode is AX.25 (as specified in [AD01]), the AX.25 frame will contain
        ///the default callsigns as they are set in the controller at the time this command is received.
        ///This command will disable any beacon that is currently being transmitted by the transceiver.
        ///The frame will not be added to the frame buffer if:
        ///      The frame buffer is full
        ///      The content size is 0 bytes
        ///      The content size is larger than the maximum size (specified in [AD01])
        /// </summary>
        /// <param name="frame">
        /// [001 - N] n/a, binary
        ///Contents of the AX.25 frame's INFO field or HDLC payload field. The contents have a
        ///minimum size of 1 byte and a maximum size specified in [AD01] (default value is 235 bytes).
        /// </param>
        /// <returns>
        /// [000 - 000] xxxxxxxx
        ///Number of remaining available 'slots' in the transmission buffer of the transmitter after this
        ///frame has been added. The minimum value of this response is 0 (meaning the buffer is full)
        ///and the maximum value of this response is the transmission frame buffer size as specified in
        ///the device configuration (This configuration is defined in the Test Report document delivered
        ///with this manual). If the response has a value of 255 (or 0xFF in hexadecimal) then the frame
        ///was not added to the buffer.
        /// </returns>
        public byte[] sendFrame(byte[] Frame)
        {
            return null;
        }

        /// <summary>
        /// Adds an AX.25 UI frame to the frame buffer of the transmitter. This AX.25 frame will contain
        /// the callsigns as specified in the command, ignoring the callsigns set in the receiver. This
        /// command will disable any beacon that is currently being transmitted by the transceiver. The
        /// AX.25 frame will not be added to the frame buffer if:
        ///      The frame buffer is full
        ///      The content size is 0 bytes
        ///      The content size is larger than the maximum size (specified in [AD01])
        /// This command is only available if the radio is set in AX.25 mode in [AD01].
        /// </summary>
        /// <param name="frame">
        /// [001 - 007] n/a, ASCII & binary:
        /// AX.25 TO callsign to be used when transmitting this AX.25 frame. The first 6 bytes should be
        ///ASCII characters, while the 7th byte should be a number (binary encoded between 0 and 15,
        ///usually 0).
        ///
        /// [008 - 014] n/a, ASCII & binary:
        /// AX.25 FROM callsign to be used when transmitting this AX.25 frame. The first 6 bytes should
        ///be ASCII characters, while the 7th byte should be a number (binary encoded between 0 and 15, usually 0).
        /// 
        /// [015 - N] n/a, binary:
        /// Contents of the AX.25 frame's INFO field. The contents have a minimum size of 1 byte and a
        ///maximum size specified in [AD01] (default value is 235 bytes).
        /// </param>
        /// <returns>
        /// Number of remaining available 'slots' in the transmission buffer of the ITC after this frame has
        ///been added. The minimum value of this response is 0 (meaning the buffer is full) and the
        ///maximum value of this response is the transmission frame buffer size as specified in the
        ///device configuration (This configuration is defined in the Test Report document delivered with
        ///this manual). If the response has a value of 255 (or 0xFF in hexadecimal) then the frame was
        ///not added to the buffer.
        /// </returns>
        public byte[] SendFrameWithCS(byte[] Frame)
        {

            return null;
        }

        /// <summary>
        /// Sets the transceiver to autonomously repeat transmission of a beacon message contained in
        /// an AX.25 UI frame or HDLC frame (mode is specified in [AD01]. The AX.25 frame will contain
        /// the default callsigns as they are set in the transmitter at the time this command is received.
        /// This command will remove any frame that is stored in the frame buffer waiting for
        /// transmission. The first transmission of the beacon message will take place when this
        /// command is received. If the transceiver is not in nominal telemetry mode, this command will
        /// have no effect.
        /// </summary>
        /// <param name="Beacon">
        /// [001 - 002] xxxxxxxx 0000xxxx
        /// Repeat interval of the beacon in seconds. This is the interval between the starts of two
        /// transmissions of the beacon. This interval has a minimum value of 0 and a maximum value of
        /// 3000. If an interval of more than 3000 seconds is specified, the interval will automatically be
        /// set to 3000. The least significant byte should be sent first (little endian).
        /// [003 – N] n/a, binary
        /// Contents of the AX.25 frame's INFO field. The contents have a minimum size of 1 byte and a
        /// maximum size specified in [AD01] (default value is 235 bytes).
        /// </param>
        public void SetBeacon(byte[] Beacon)
        {

        }

        /// <summary>
        /// Sets the transceiver to autonomously repeat transmission of a beacon message contained in
        /// an AX.25 UI frame. This AX.25 frame will contain the callsigns as specified in the command,
        /// ignoring the callsigns set in the receiver. This command will remove any AX.25 frames that
        /// are stored in the frame buffer waiting for transmission. The first transmission of the beacon
        /// message will take place when this command is received. If the transceiver is not in nominal
        /// telemetry mode, this command will have no effect. This command is only available if the radio
        ///is set in AX.25 mode in [AD01].
        /// </summary>
        /// <param name="Beacon">
        /// [001 - 002] xxxxxxxx 0000xxxx:
        /// Repeat interval of the beacon in seconds. This is the interval between the starts of two
        /// transmissions of the beacon. This interval has a minimum value of 0 and a maximum value of
        /// 3000. If an interval of more than 3000 seconds is specified, the interval will automatically be
        /// set to 3000.
        /// 
        /// [003 - 009] n/a, ASCII & binary:
        /// /// AX.25 TO callsign to be used when transmitting this AX.25 frame. The first 6 bytes should be
        /// ASCII characters, while the 7th byte should be a number (binary encoded between 0 and 15,
        /// usually 0).
        /// 
        /// [010 - 016] n/a, ASCII & binary:
        /// AX.25 FROM callsign to be used when transmitting this AX.25 frame. The first 6 bytes should
        /// be ASCII characters, while the 7th byte should be a number (binary encoded between 0 and
        /// 15, usually 0).
        /// 
        /// [017 – N] n/a, binary:
        /// Contents of the AX.25 frame's INFO field. The content has a minimum size of 1 byte and a
        /// maximum size specified in [AD01] (default value is 235 bytes).

        /// </param>
        public void SetBeaconWithCS(byte[] Beacon)
        {

        }

        /// <summary>
        /// Clears any beacon that is currently set in the transceiver. If a beacon transmission is currently
        ///in progress, this transmission will be completed.
        /// </summary>
        public void clearBeacon()
        {


        }
        /// <summary>
        ///Sets the default AX.25 TO callsign in the transmitter.This callsign is included in AX.25 frames
        ///and AX.25 beacon transmissions that are transmitted using the default callsigns(see sections
        ///6.2.2.2 and 6.2.2.5).
        ///This command is only available if the radio is set in AX.25 mode in [AD01].
        ///Parameters
        /// </summary>
        /// <param name="AX">
        /// [001 - 007] n/a, ASCII & binary
        ///AX.25 TO callsign to be used for AX.25 frames.The first 6 bytes should be ASCII characters,
        ///while the 7th byte should be a number(binary encoded between 0 and 15, usually 0).        ///</param>
        public void setDefaultAXtoCallsign(byte[] AX)
        {

        }

        /// <summary>
        ///Sets the default AX.25 FROM callsign in the transmitter. This callsign is included in AX.25
        ///frames and AX.25 beacon transmissions that are transmitted using the default callsigns.
        ///This command is only available if the radio is set in AX.25 mode in [AD01].
        ///Parameters
        /// </summary>
        /// <param name="CS">
        /// [001 - 007] n/a, ASCII & binary
        ///AX.25 FROM callsign to be used for AX.25 frames.The first 6 bytes should be ASCII
        ///characters, while the 7th byte should be a number(binary encoded between 0 and 15, usually
        ///0).        ///</param>
        public void setDefaultAXfromCallsign(byte[] CS)
        {

        }

        /// <summary>
        /// Sets the state of the transmitter when it's idle. The transmitter can either be set to either
        ///remain or switch off when it's idle. When it's set to switch off, this will happen when there are
        ///no frames in the frame buffer or no beacon transmission is scheduled to occur.As soon as the
        ///transmitter needs to transmit a beacon or data it will switch on again.When the transmitter is
        ///idle but is set to remain on, it will transmit an idle sequence to help the ground receiver to
        ///lock
        /// </summary>
        /// <param name="idle">
        /// [001 - 001] 0000000x
        ///The idle state of the transmitter to be set.The values listed below correspond to the available
        ///states.If another value is specified this command will have no effect.
        ///00000000 - transmitter is turned off when idle
        ///00000001 - transmitter remains on when idle
        ///</param>
        public void setTxIdleState(byte[] idle)
        {

        }

        /// <summary>
        /// Measures all the telemetry channels:
        /// Instantaneous RF reflected power from transmitter port
        /// Instantaneous RF forward power from transmitter port
        /// Power amplifier temperature
        /// Transmitter supply current
        /// </summary>
        /// <returns>
        /// [000 - 001] xxxxxxxx 0000xxxx
        ///Raw measurement value of the instantaneous RF reflected power at the transmitter port.This
        ///field is valid only during transmission.The least significant byte is sent first (little endian).
        ///[002 - 003]
        ///xxxxxxxx 0000xxxx
        ///Raw measurement value of the power amplifier temperature.This field is valid only during
        ///transmission.The least significant byte is sent first (little endian).
        ///[004 - 005]
        ///xxxxxxxx 0000xxxx
        ///Raw measurement value of the instantaneous RF forward power at the transmitter port.The
        ///least significant byte is sent first (little endian).
        ///[006 - 007]
        ///xxxxxxxx 0000xxxx
        ///Raw measurement value of the transmitter supply current.The least significant byte is sent
        ///first(little endian).
        ///
        ///All these measurements have a minimum value of 0 and a maximum value of 4095. Please
        ///refer to Section 7.5 for the conversion formulas.
        /// </returns>
        public byte[] measureAllTLMchannels()
        {
            return null;
        }

        /// <summary>
        /// Provides the telemetry channels that were sampled during the last frame transmission:
        /// Instantaneous RF reflected power from transmitter port
        /// Instantaneous RF forward power from transmitter port
        /// Power amplifier temperature
        /// Transmitter current consumption
        /// </summary>
        /// <returns>
        /// [000 - 001] xxxxxxxx 0000xxxx
        ///Raw measurement value of the instantaneous RF reflected power at the transmitter port.This
        ///field is valid only during transmission.The least significant byte is sent first (little endian).
        ///[002 - 003]
        ///xxxxxxxx 0000xxxx
        ///Raw measurement value of the power amplifier temperature.This field is valid only during
        ///transmission.The least significant byte is sent first (little endian).
        ///[004 - 005]
        ///xxxxxxxx 0000xxxx
        ///Raw measurement value of the instantaneous RF forward power at the transmitter port.The
        ///least significant byte is sent first (little endian).
        ///[006 - 007]
        ///xxxxxxxx 0000xxxx
        ///Raw measurement value of the transmitter supply current.The least significant byte is sent
        ///first(little endian).
        ///
        ///All these measurements have a minimum value of 0 and a maximum value of 4095. Please
        ///refer to Section 7.5 for the conversion formulas.
        /// </returns>
        public byte[] getTLMchannelsDuringLastTx()
        {
            return null;
        }

        /// <summary>
        /// Changes the bitrate used: the modification will take effect immediately, possibly in the middle
        ///of transmitting a frame.
        /// </summary>
        /// <param name="bitrate">
        /// [001 - 001] 0000xxxx
        ///Transmission bitrate.The values listed below correspond to the available bitrates. If another
        ///value is specified this command will have no effect.
        ///00000001 - 1200 bits per second
        ///00000010 - 2400 bits per second
        ///00000100 - 4800 bits per second
        ///00001000 - 9600 bits per second
        /// </param>
        public void setTxBitrate(byte[] bitrate)
        {

        }

        /// <summary>
        /// Reports the amount of time the transmitter MCU has been active since the last reset, also
        ///known as up- time.The uptime is reported with a resolution of 1 second.The maximum
        ///supported uptime is 255 days, 23 hours, 59 minutes and 59 seconds, after which the uptime
        ///will overflow and the reported uptime will be 0 days, 0 hours, 0 minutes and 0 seconds.
        ///Please note that this is not the time that the transmitter has been active.
        /// </summary>
        /// <returns>
        /// [000 - 000] 00xxxxxx
        ///Second part of the uptime value.This part has a minimum value of 0 and a maximum value
        ///of 59.
        ///[001 - 001] 000xxxxx
        ///Minute part of the uptime value.This part has a minimum value of 0 and a maximum value of
        ///59.
        ///[002 - 002] 000xxxxx
        ///Hour part of the uptime value.This part has a minimum value of 0 and a maximum value of
        ///23.
        ///[003 - 003] xxxxxxxx
        ///Day part of the uptime value.This part has a minimum value of 0 and a maximum value of
        ///255.
        /// </returns>
        public byte[] reportTxUptime()
        {
            return null;
        }


        /// <summary>
        /// Reports general information about the state the transmitter is currently in.
        /// </summary>
        /// <returns>
        /// [000 - 000] 0xxxxxxx
        ///Status of the transmitter.The following information is contained in this value:
        ///      Transmitter idle state
        ///xxxxxxx0 - transmitter is turned off when idle
        ///xxxxxxx1 - transmitter remains on when idle
        ///      Beacon active
        ///xxxxxx0x - no beacon has been set
        ///xxxxxx1x - a beacon is active
        ///      Transmitter bit rate
        ///xxxx00xx - 1200 bits per second
        ///xxxx01xx - 2400 bits per second
        ///xxxx10xx - 4800 bits per second
        ///xxxx11xx - 9600 bits per second
        /// </returns>
        public byte[] reportTxState()
        {
            return null;
        }

    }
}
