scriptcs-logger
===============

# About #

This [Script Pack](https://github.com/scriptcs/scriptcs/wiki) for [scriptcs](http://scriptcs.net/) provides a simple logger.

This script pack allows a log level to be set at the script level and provides the following methods to write out messages at the appropriate log leve :

- Error
- Warn
- Info
- Debug

# Installation #

Install the nuget package by running

	scriptcs -install ScriptCs.Logger.ScriptPack

# Usage #

Obtain a reference to the Script Pack.

    var logger = Require<Logger>();

You can then log messages at different log levels as follows:
	
	logger.Error("Error message.");
	logger.Warn("Warning message.");
	logger.Debug("Debug message.");
	logger.Info("Info message.");

# Configuration #

The log level for your script can be configured via script arguments as follows:

	> scriptcs logger.csx -- -loglevel warn

This will only log the messages for warnings and below. The log levels are ordered as follows:

	Error 	= 1,
    Warn 	= 2,
    Info 	= 3,
    Debug 	= 4 

# Sample #

A example of how to use the Script Pack is available in the ``sample`` folder. 